using System.Linq;
using System.Collections.Generic;
using MKH.Permission.Model.SoftwareAccess;
using System;
using System.Windows.Forms;
using MKH.Library.Clasess.FilterClass;

namespace MKH.Permission.View.BaseForms
{
    public partial class SoftwareAccess_Frm : System.Windows.Forms.Form
    {
        int _software_Id = 0;
        public SoftwareAccess_Frm(int Software_Id)
        {
            InitializeComponent();
            _software_Id = Software_Id;
        }

        public void BindData()
        {
            CreateTree();
            TreeViewSoftwareAccess.ExpandAll();
        }

        TreeNode Treechild;
        private void CreateTree()
        {
            try
            {
                TreeViewSoftwareAccess.Nodes.Clear();

                string str ="";
                List<QueryFilter.ExpressionBuilder.Filter> filter = new List<QueryFilter.ExpressionBuilder.Filter>();
                filter.Add(
                new QueryFilter.ExpressionBuilder.Filter
                {
                    PropertyName = "ParentId",
                    Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                    Value = 0,
                    OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
                }
                );


                foreach (VW_SoftwareAccess item in new ViewModel.SoftwareAccess.SoftwareAccess().GetAllListByFilter(filter, ref str))
                {
                    Treechild = new TreeNode(item.ResourceNameFarsi + " [" + item.Id.ToString() + "]"); //+ "[" + item.ResourceName+"]");
                    Treechild.ToolTipText = item.Id.ToString();
                    Treechild.Tag = item.ParentId;
                    TreeViewSoftwareAccess.Nodes.Add(Treechild);
                    RecerciveBindNode(Treechild);
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void RecerciveBindNode(TreeNode parent)
        {
            try
            {
                string str ="";
                List<QueryFilter.ExpressionBuilder.Filter> filter = new List<QueryFilter.ExpressionBuilder.Filter>();
                filter.Add(
                new QueryFilter.ExpressionBuilder.Filter
                {
                    PropertyName = "ParentId",
                    Operation = QueryFilter.ExpressionBuilder.Op.Equals,
                    Value = parent.ToolTipText.ToInt(),
                    OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
                }
                );



                foreach (VW_SoftwareAccess item in new ViewModel.SoftwareAccess.SoftwareAccess().GetAllListByFilter(filter,ref str))
                {
                    Treechild = new TreeNode(item.ResourceNameFarsi + " [" + item.Id.ToString() + "]");// + "[" + item.ResourceName+"]");
                    Treechild.ToolTipText = item.Id.ToString();

                    Treechild.Tag = item.ParentId.ToString();
                    parent.Nodes.Add(Treechild);
                    RecerciveBindNode(Treechild);
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        #region All UI Button

        private void buttonItemNodeAdd_Click(object sender, EventArgs e)
        {
            SoftwareAccessAdd_Frm SoftwareAccessAdd = null;
            try
            {
                SoftwareAccessAdd = new SoftwareAccessAdd_Frm(_software_Id,
                    int.Parse(TreeViewSoftwareAccess.SelectedNode.Tag.ToString() ?? "0"),
                    TreeViewSoftwareAccess.SelectedNode.FullPath.FewCharsToString('\\'));
            }
            catch
            {
                SoftwareAccessAdd = new SoftwareAccessAdd_Frm(_software_Id, 0, 0);
            }

            SoftwareAccessAdd.ShowDialog();
            BindData();
        }

        private void buttonItemChildAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SoftwareAccessAdd_Frm SoftwareAccessAdd = new SoftwareAccessAdd_Frm(_software_Id, int.Parse(TreeViewSoftwareAccess.SelectedNode.ToolTipText), TreeViewSoftwareAccess.SelectedNode.FullPath.FewCharsToString('\\') + 1);
                SoftwareAccessAdd.ShowDialog();
            }
            catch { }
            BindData();
        }

        private void headerGridSoftwareAccess_btnEditClick(object sender, System.EventArgs e)
        {
            SoftwareAccessAdd_Frm SoftwareAccessAdd = new SoftwareAccessAdd_Frm(
                int.Parse(TreeViewSoftwareAccess.SelectedNode.ToolTipText.ToString()), _software_Id, int.Parse(TreeViewSoftwareAccess.SelectedNode.Tag.ToString()), TreeViewSoftwareAccess.SelectedNode.FullPath.FewCharsToString('\\'));
            SoftwareAccessAdd.ShowDialog();
            BindData();
        }

        private void headerGridSoftwareAccess_btnDeleteClick(object sender, System.EventArgs e)
        {
            if (MKH.Library.Clasess.MSSMessage.MSSMessage_View(0, MKH.Library.Clasess.MSSMessage.MessageType.SConfirmation,true, "آیا به حذف این مورد اطمینان دارید؟"))
            {
                try
                {
                    List<TBL_SoftwareAccess> Ls = new List<TBL_SoftwareAccess>();
                    TBL_SoftwareAccess SoftwareAccess = new TBL_SoftwareAccess();
                    SoftwareAccess.Id = int.Parse(TreeViewSoftwareAccess.SelectedNode.ToolTipText.ToString());
                    Ls.Add(SoftwareAccess);

                    string str = "";
                    new ViewModel.SoftwareAccess.SoftwareAccess().DeleteEntity(Ls, ref str);
                }
                catch 
                {
                    MKH.Library.Clasess.MSSMessage.MSSMessage_View("امکان حذف این مورد در سیستم وجود ندارد", MKH.Library.Clasess.MSSMessage.MessageType.SError);
                }
            }
            BindData();
        }

        #endregion

        private void SoftwareAccess_Frm_Load(object sender, System.EventArgs e)
        {
            BindData();
        }

        private void buttonItemRefresh_Click(object sender, EventArgs e)
        {
            BindData();
        }


    }
}
