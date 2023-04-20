using System.Linq;
using System.Collections.Generic;
using MKH.Permission.Model.SoftwareAccessUser;
using MKH.Permission.Model.SoftwareAccess;
using System;
using System.Windows.Forms;
using MKH.Library.Clasess.FilterClass;

namespace MKH.Permission.View.BaseForms
{
    public partial class SoftwareAccessUser_Frm : MKH.Library.Forms.MSSBaseNew_frm
    {
        int _software_Id = 0, _user_Id = 0;
        public SoftwareAccessUser_Frm(int Software_Id, int User_Id, string UserFullName)
        {
            InitializeComponent();
            _software_Id = Software_Id;
            _user_Id = User_Id;
            LabelFullName.Text = UserFullName;
        }

        public void BindData()
        {
            CreateTree();
            SetTree();
            //TreeViewSoftwareAccessUser.ExpandAll();
        }


        TreeNode Treechild;
        private void CreateTree()
        {
            try
            {
                TreeViewSoftwareAccessUser.Nodes.Clear();

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
                    Treechild = new TreeNode();
                    Treechild.Text = item.ResourceNameFarsi + " [" + item.Id.ToString() + "]";// + "[" + item.ResourceName+"]";
                    Treechild.Name = item.Id.ToString();
                    Treechild.ToolTipText = item.ParentId.ToString();
                    TreeViewSoftwareAccessUser.Nodes.Add(Treechild);
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
                    Value = parent.Name.ToInt(),
                    OperationFilter = QueryFilter.ExpressionBuilder.OpFilter.And
                }
                );

                foreach (VW_SoftwareAccess item in new ViewModel.SoftwareAccess.SoftwareAccess().GetAllListByFilter(filter,ref str))
                {
                    Treechild = new TreeNode();
                    Treechild.Text = item.ResourceNameFarsi + " [" + item.Id.ToString() + "]";// + "[" + item.ResourceName + "]";
                    Treechild.Name = item.Id.ToString();
                    Treechild.ToolTipText = item.ParentId.ToString();
                    parent.Nodes.Add(Treechild);
                    RecerciveBindNode(Treechild);
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

 
        private void SoftwareAccessUser_Frm_Load(object sender, System.EventArgs e)
        {
            BindData();
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            SetTreeNode(TreeViewSoftwareAccessUser, true);
        }

        private void ButtonDeselect_Click(object sender, EventArgs e)
        {
            SetTreeNode(TreeViewSoftwareAccessUser, false);
        }

        private void SetTree()
        {
            string str = "";


            foreach (TreeNode item in TreeViewSoftwareAccessUser.Nodes)
            {
                item.Checked = new ViewModel.SoftwareAccessUser.SoftwareAccessUser().GetAllListByID(int.Parse(item.Name), _user_Id, ref str).Count != 0;
                SetAllNodeTree(item);
            }
        }

        private void SetAllNodeTree(TreeNode TN)
        {
            string str = "";

            foreach (TreeNode cn in TN.Nodes)
            {
                cn.Checked = new ViewModel.SoftwareAccessUser.SoftwareAccessUser().GetAllListByID(int.Parse(cn.Name), _user_Id, ref str).Count != 0;
                SetAllNodeTree(cn);
            }
        }





        private void SetTreeNode(TreeView TN, bool itemchecked)
        {
            foreach (TreeNode item in TN.Nodes)
            {
                item.Checked = itemchecked;
                SetAllNode(item, itemchecked);
            }
        }

        private void SetAllNode(TreeNode TN, bool itemchecked)
        {
            foreach (TreeNode cn in TN.Nodes)
            {
                cn.Checked = itemchecked;
                SetAllNode(cn, itemchecked);
            }
        }

        string str = "";
        private void buttonItemOK_Click(object sender, EventArgs e)
        {
            List<TBL_SoftwareAccessUser> Ls = new List<TBL_SoftwareAccessUser>();

            foreach (VW_SoftwareAccessUser item in new ViewModel.SoftwareAccessUser.SoftwareAccessUser().GetAllList(ref str))
            {
                if (item.User_Id == _user_Id)
                {
                    TBL_SoftwareAccessUser SU = new TBL_SoftwareAccessUser();
                    SU.User_Id = _user_Id;
                    SU.SoftwareAccess_Id = item.SoftwareAccess_Id;
                    Ls.Add(SU);
                }
            }

            new ViewModel.SoftwareAccessUser.SoftwareAccessUser().DeleteEntity(Ls, ref str);

            SaveTree();

            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void SaveTree()
        {
            foreach (TreeNode item in TreeViewSoftwareAccessUser.Nodes)
            {
                if (item.Checked)
                {
                    int? idSet = 0;
                    List<TBL_SoftwareAccessUser> Ls = new List<TBL_SoftwareAccessUser>();
                    TBL_SoftwareAccessUser SU = new TBL_SoftwareAccessUser();
                    SU.SoftwareAccess_Id = int.Parse(item.Name);
                    SU.User_Id = _user_Id;
                    Ls.Add(SU);
                    new ViewModel.SoftwareAccessUser.SoftwareAccessUser().InsertEntity(Ls, ref str, ref idSet);
                }

                SaveAllNodeTree(item);
            }
        }


        private void SaveAllNodeTree(TreeNode TN)
        {
            string str = "";

            foreach (TreeNode cn in TN.Nodes)
            {
                if (cn.Checked)
                {
                    int? idSet = 0;
                    List<TBL_SoftwareAccessUser> Ls = new List<TBL_SoftwareAccessUser>();
                    TBL_SoftwareAccessUser SU = new TBL_SoftwareAccessUser();
                    SU.SoftwareAccess_Id = int.Parse(cn.Name);
                    SU.User_Id = _user_Id;
                    Ls.Add(SU);
                    new ViewModel.SoftwareAccessUser.SoftwareAccessUser().InsertEntity(Ls, ref str, ref idSet);
                }
                SaveAllNodeTree(cn);
            }
        }

    }
}
