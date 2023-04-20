using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace MKH.Permission.ViewModel.Security
{
    public class MSSCheckPermission_cls
    {
        public void CheckPermissionControl(Form FormControl)
        {
            if (MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.IsAdmin) return;

            string str = "";
            foreach (Control item in FormControl.Controls)
            {
                if (item is MKH.Library.Control.MSSHeaderGrid)
                {
                    foreach (DevComponents.DotNetBar.ButtonItem item1 in (item as MKH.Library.Control.MSSHeaderGrid).Items)
                    {
                        try
                        {
                            if (item1.Tag == null || item1.Tag.ToString() == "" || item1.Tag.ToString() == "0") continue;
                            item1.Enabled = new ViewModel.SoftwareAccessUser.SoftwareAccessUser().GetAllListByID(Convert.ToInt32(item1.Tag), MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, ref str).Count != 0;
                        }
                        catch { }

                        foreach (DevComponents.DotNetBar.ButtonItem item2 in (item1 as DevComponents.DotNetBar.ButtonItem).SubItems)
                        {
                            try
                            {
                                if (item2.Tag != null && item2.Tag.ToString() != "" && item2.Tag.ToString() != "0")
                                    item2.Enabled = new ViewModel.SoftwareAccessUser.SoftwareAccessUser().GetAllListByID(Convert.ToInt32(item2.Tag), MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, ref str).Count != 0;
                            }
                            catch { }

                        }
                    }
                }
                if (item is MKH.Library.Control.MSSRibbonBar)
                {
                    foreach (DevComponents.DotNetBar.ButtonItem item1 in (item as MKH.Library.Control.MSSRibbonBar).Items)
                    {
                        try
                        {
                            if (item1.Tag == null || item1.Tag.ToString() == "" || item1.Tag.ToString() == "0") continue;
                            item1.Enabled = new ViewModel.SoftwareAccessUser.SoftwareAccessUser().GetAllListByID(Convert.ToInt32(item1.Tag), MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, ref str).Count != 0;
                        }
                        catch { }
                    }
                }



                if (item is MKH.Library.Control.MSSRibbonControl)
                {
                    foreach (Control item1 in (item as MKH.Library.Control.MSSRibbonControl).Controls)
                    {
                        try
                        {
                            if (item1.Tag != null && item1.Tag.ToString() != "" && item1.Tag.ToString() != "0")
                                item1.Enabled = new ViewModel.SoftwareAccessUser.SoftwareAccessUser().GetAllListByID(Convert.ToInt32(item1.Tag), MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, ref str).Count != 0;
                        }
                        catch { }
                        try
                        {
                            foreach (Control item2 in (item1 as DevComponents.DotNetBar.RibbonPanel).Controls)
                            {
                                try
                                {
                                    if (item2.Tag != null && item2.Tag.ToString() != "" && item2.Tag.ToString() != "0")
                                        item2.Enabled = new ViewModel.SoftwareAccessUser.SoftwareAccessUser().GetAllListByID(Convert.ToInt32(item2.Tag), MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, ref str).Count != 0;
                                }
                                catch { }
                                foreach (DevComponents.DotNetBar.ButtonItem item3 in (item2 as DevComponents.DotNetBar.RibbonBar).Items)
                                {
                                    try
                                    {
                                        if (item3.Tag != null && item3.Tag.ToString() != "" && item3.Tag.ToString() != "0")
                                            item3.Enabled = new ViewModel.SoftwareAccessUser.SoftwareAccessUser().GetAllListByID(Convert.ToInt32(item3.Tag), MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, ref str).Count != 0;
                                    }
                                    catch { }
                                    foreach (DevComponents.DotNetBar.ButtonItem item4 in (item3 as DevComponents.DotNetBar.ButtonItem).SubItems)
                                    {
                                        try
                                        {
                                            if (item4.Tag != null && item4.Tag.ToString() != "" && item4.Tag.ToString() != "0")
                                                item4.Enabled = new ViewModel.SoftwareAccessUser.SoftwareAccessUser().GetAllListByID(Convert.ToInt32(item4.Tag), MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, ref str).Count != 0;
                                        }
                                        catch { }

                                        foreach (DevComponents.DotNetBar.ButtonItem item5 in (item4 as DevComponents.DotNetBar.ButtonItem).SubItems)
                                        {
                                            try
                                            {
                                                if (item5.Tag != null && item5.Tag.ToString() != "" && item5.Tag.ToString() != "0")
                                                    item5.Enabled = new ViewModel.SoftwareAccessUser.SoftwareAccessUser().GetAllListByID(Convert.ToInt32(item5.Tag), MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, ref str).Count != 0;
                                            }
                                            catch { }

                                        }
                                    }
                                }
                               
                            }
                        }
                        catch { }
                    }
                }

                if (item is DevComponents.DotNetBar.Bar)
                {
                    foreach (Control item1 in (item as DevComponents.DotNetBar.Bar).Controls)
                    {
                        try
                        {
                            if (item1.Tag == null || item1.Tag.ToString() == "" || item1.Tag.ToString() == "0") continue;
                            item1.Enabled = new ViewModel.SoftwareAccessUser.SoftwareAccessUser().GetAllListByID(Convert.ToInt32(item1.Tag), MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, ref str).Count != 0;
                        }
                        catch { }
                    }
                }
                if (item is MKH.Library.Control.MSSGroupPanel)
                {
                    foreach (Control item1 in (item as MKH.Library.Control.MSSGroupPanel).Controls)
                    {
                        try
                        {
                            if (item1.Tag == null || item1.Tag.ToString() == "" || item1.Tag.ToString() == "0") continue;
                            item1.Enabled = new ViewModel.SoftwareAccessUser.SoftwareAccessUser().GetAllListByID(Convert.ToInt32(item1.Tag), MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, ref str).Count != 0;
                        }
                        catch { }
                    }
                }

                if (item is MKH.Library.Control.MSSPanel)
                {
                    foreach (Control item1 in (item as MKH.Library.Control.MSSPanel).Controls)
                    {
                        try
                        {
                            if (item1.Tag == null || item1.Tag.ToString() == "" || item1.Tag.ToString() == "0") continue;
                            item1.Enabled = new ViewModel.SoftwareAccessUser.SoftwareAccessUser().GetAllListByID(Convert.ToInt32(item1.Tag), MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, ref str).Count != 0;
                        }
                        catch { }
                    }
                }

                if (item is DevComponents.DotNetBar.TabControlPanel)
                {
                    try
                    {
                        if (item.Tag == null || item.Tag.ToString() == "" || item.Tag.ToString() == "0") continue;
                        item.Enabled = new ViewModel.SoftwareAccessUser.SoftwareAccessUser().GetAllListByID(Convert.ToInt32(item.Tag), MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, ref str).Count != 0;
                    }
                    catch { }
                }

            }
        }

        public void CheckPermissionControl(UserControl FormControl)
        {
            if (MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.IsAdmin) return;

            string str = "";
            try
            {
                foreach (Control item in FormControl.Controls)
                {
                    if (item is MKH.Library.Control.MSSHeaderGrid)
                    {
                        foreach (DevComponents.DotNetBar.ButtonItem item1 in (item as MKH.Library.Control.MSSHeaderGrid).Items)
                        {
                            try
                            {
                                if (item1.Tag == null || item1.Tag.ToString() == "" || item1.Tag.ToString() == "0") continue;
                                item1.Enabled = new ViewModel.SoftwareAccessUser.SoftwareAccessUser().GetAllListByID(Convert.ToInt32(item1.Tag), MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, ref str).Count != 0;
                            }
                            catch { }
                            
                            foreach (DevComponents.DotNetBar.ButtonItem item2 in (item1 as DevComponents.DotNetBar.ButtonItem).SubItems)
                            {
                                try
                                {
                                    if (item2.Tag != null && item2.Tag.ToString() != "" && item2.Tag.ToString() != "0")
                                        item2.Enabled = new ViewModel.SoftwareAccessUser.SoftwareAccessUser().GetAllListByID(Convert.ToInt32(item2.Tag), MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, ref str).Count != 0;
                                }
                                catch { }

                            }
                        }

                    }
                    if (item is MKH.Library.Control.MSSRibbonBar)
                    {
                        foreach (DevComponents.DotNetBar.ButtonItem item1 in (item as MKH.Library.Control.MSSRibbonBar).Items)
                        {
                            try
                            {
                                if (item1.Tag == null || item1.Tag.ToString() == "" || item1.Tag.ToString() == "0") continue;
                                item1.Enabled = new ViewModel.SoftwareAccessUser.SoftwareAccessUser().GetAllListByID(Convert.ToInt32(item1.Tag), MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, ref str).Count != 0;
                            }
                            catch { }
                        }
                    }



                    if (item is MKH.Library.Control.MSSRibbonControl)
                    {
                        foreach (Control item1 in (item as MKH.Library.Control.MSSRibbonControl).Controls)
                        {
                            try
                            {
                                if (item1.Tag != null && item1.Tag.ToString() != "" && item1.Tag.ToString() != "0")
                                    item1.Enabled = new ViewModel.SoftwareAccessUser.SoftwareAccessUser().GetAllListByID(Convert.ToInt32(item1.Tag), MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, ref str).Count != 0;
                            }
                            catch { }
                            try
                            {
                                foreach (Control item2 in (item1 as DevComponents.DotNetBar.RibbonPanel).Controls)
                                {
                                    try
                                    {
                                        if (item2.Tag != null && item2.Tag.ToString() != "" && item2.Tag.ToString() != "0")
                                            item2.Enabled = new ViewModel.SoftwareAccessUser.SoftwareAccessUser().GetAllListByID(Convert.ToInt32(item2.Tag), MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, ref str).Count != 0;
                                    }
                                    catch { }
                                    foreach (DevComponents.DotNetBar.ButtonItem item3 in (item2 as DevComponents.DotNetBar.RibbonBar).Items)
                                    {
                                        try
                                        {
                                            if (item3.Tag != null && item3.Tag.ToString() != "" && item3.Tag.ToString() != "0")
                                                item3.Enabled = new ViewModel.SoftwareAccessUser.SoftwareAccessUser().GetAllListByID(Convert.ToInt32(item3.Tag), MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, ref str).Count != 0;

                                        }
                                        catch { }
                                        
                                        foreach (DevComponents.DotNetBar.ButtonItem item4 in (item3 as DevComponents.DotNetBar.ButtonItem).SubItems)
                                        {
                                            try
                                            {
                                                if (item4.Tag != null && item4.Tag.ToString() != "" && item4.Tag.ToString() != "0")
                                                    item4.Enabled = new ViewModel.SoftwareAccessUser.SoftwareAccessUser().GetAllListByID(Convert.ToInt32(item4.Tag), MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, ref str).Count != 0;
                                            }
                                            catch { }

                                        }
                                    }
                                }
                            }
                            catch { }
                        }
                    }

                    if (item is DevComponents.DotNetBar.Bar)
                    {
                        foreach (Control item1 in (item as DevComponents.DotNetBar.Bar).Controls)
                        {
                            try
                            {
                                if (item1.Tag == null || item1.Tag.ToString() == "" || item1.Tag.ToString() == "0") continue;
                                item1.Enabled = new ViewModel.SoftwareAccessUser.SoftwareAccessUser().GetAllListByID(Convert.ToInt32(item1.Tag), MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, ref str).Count != 0;
                            }
                            catch { }
                        }
                    }
                    if (item is MKH.Library.Control.MSSGroupPanel)
                    {
                        foreach (Control item1 in (item as MKH.Library.Control.MSSGroupPanel).Controls)
                        {
                            try
                            {
                                if (item1.Tag == null || item1.Tag.ToString() == "" || item1.Tag.ToString() == "0") continue;
                                item1.Enabled = new ViewModel.SoftwareAccessUser.SoftwareAccessUser().GetAllListByID(Convert.ToInt32(item1.Tag), MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, ref str).Count != 0;
                            }
                            catch { }
                        }
                    }

                    if (item is MKH.Library.Control.MSSPanel)
                    {
                        foreach (Control item1 in (item as MKH.Library.Control.MSSPanel).Controls)
                        {
                            try
                            {
                                if (item1.Tag == null || item1.Tag.ToString() == "" || item1.Tag.ToString() == "0") continue;
                                item1.Enabled = new ViewModel.SoftwareAccessUser.SoftwareAccessUser().GetAllListByID(Convert.ToInt32(item1.Tag), MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, ref str).Count != 0;
                            }
                            catch { }
                        }
                    }

                    if (item is DevComponents.DotNetBar.TabControlPanel)
                    {
                        try
                        {
                            if (item.Tag == null || item.Tag.ToString() == "" || item.Tag.ToString() == "0") continue;
                            item.Enabled = new ViewModel.SoftwareAccessUser.SoftwareAccessUser().GetAllListByID(Convert.ToInt32(item.Tag), MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, ref str).Count != 0;
                        }
                        catch { }
                    }

                    if (item is MKH.Library.Control.MSSContextMenuStrip)
                    {
                        try
                        {
                            if (item.Tag == null || item.Tag.ToString() == "" || item.Tag.ToString() == "0") continue;
                            item.Enabled = new ViewModel.SoftwareAccessUser.SoftwareAccessUser().GetAllListByID(Convert.ToInt32(item.Tag), MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, ref str).Count != 0;
                        }
                        catch { }
                    }
                    //if (item is MKH.Library.Control.MSSGridexView)
                    //{
                    //    foreach (Janus.Windows.GridEX.GridEXColumn q in (item as MKH.Library.Control.MSSGridexView).RootTable.Columns)
                    //    {
                    //        if (q.Tag == null) continue;
                    //        if (new ViewModel.SoftwareAccessUser.SoftwareAccessUser().GetAllListByID(Convert.ToInt32(q.Tag), MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, ref str).Count != 0)
                    //            q.Tag = null;
                    //    }
                    //}

                }
            }
            catch { }
        }

        public bool CheckPermissionItem(int ItemTag)
        {
            if (MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.IsAdmin) return true;

            string str = "";
            return new ViewModel.SoftwareAccessUser.SoftwareAccessUser().GetAllListByID(ItemTag, MKH.Permission.ViewModel.Security.MSSConfiguration_cls.Instance.USERID, ref str).Count != 0;
        }


    }
}
