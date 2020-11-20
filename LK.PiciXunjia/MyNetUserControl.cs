using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFIDA.U8.Portal.Proxy.editors;
using UFIDA.U8.Portal.Framework.MainFrames;
using UFIDA.U8.Portal.Framework.Actions;
using UFIDA.U8.Portal.Proxy.Actions;

namespace LKU8.shoukuan
{
    class MyNetUserControl : INetUserControl
    {
        #region INetUserControl 成员

        UserControl1 usercontrol = null;
        //private IEditorInput _editInput = null;
        //private IEditorPart _editPart = null;
        private string _title;
        public System.Windows.Forms.Control CreateControl(UFSoft.U8.Framework.Login.UI.clsLogin login, string MenuID, string Paramters)
        {
            usercontrol = new UserControl1();
            usercontrol.Name = "LKxsxunjia";
            return usercontrol;
            //throw new NotImplementedException();
        }

        public UFIDA.U8.Portal.Proxy.Actions.NetAction[] CreateToolbar(UFSoft.U8.Framework.Login.UI.clsLogin login)
        {
            IActionDelegate nsd = new NetSampleDelegate();
            ////string skey = "mynewcontrol";
            NetAction ac = new NetAction("add", nsd);
            NetAction[] aclist;
            aclist = new NetAction[16];
            ac.Text = "增行";
            ac.Tag = usercontrol;
            ac.Image = Properties.Resources.add;
            ac.ActionType = NetAction.NetActionType.Edit;
            ac.DisplayStyle = 1;
            ac.Style = 1;
            ac.SetGroup = "增行";
            ac.SetGroupRow = 1;
            ac.RowSpan = 3;
            aclist[0] = ac;

            ac = new NetAction("del", nsd);
            //aclist = new NetAction[1];
            ac.Text = "删行";
            ac.Tag = usercontrol;
            ac.Image = Properties.Resources.Adjust_write_off;
            ac.ActionType = NetAction.NetActionType.Edit;
            ac.DisplayStyle = 1;
            ac.Style = 1;
            ac.SetGroup = "删行";
            ac.SetGroupRow = 1;
            ac.RowSpan = 3;
            aclist[1] = ac;



            ac = new NetAction("save", nsd);
            //aclist = new NetAction[1];
            ac.Text = "保存";
            ac.Tag = usercontrol;
            ac.Image = Properties.Resources.Confirm;
            ac.ActionType = NetAction.NetActionType.Edit;
            ac.DisplayStyle = 1;
            ac.Style = 1;
            ac.SetGroup = "保存";
            ac.SetGroupRow = 1;
            ac.RowSpan = 3;
            aclist[2] = ac;

            ac = new NetAction("xunjia", nsd);
            //aclist = new NetAction[1];
            ac.Text = "询价";
            ac.Tag = usercontrol;
            ac.Image = Properties.Resources.approval_query;
            ac.ActionType = NetAction.NetActionType.Edit;
            ac.DisplayStyle = 1;
            ac.Style = 1;
            ac.SetGroup = "询价";
            ac.SetGroupRow = 1;
            ac.RowSpan = 3;
            aclist[3] = ac;

            ac = new NetAction("guanbi", nsd);
            //aclist = new NetAction[1];
            ac.Text = "关闭";
            ac.Tag = usercontrol;
            ac.Image = Properties.Resources.Cancel;
            ac.ActionType = NetAction.NetActionType.Edit;
            ac.DisplayStyle = 1;
            ac.Style = 1;
            ac.SetGroup = "关闭";
            ac.SetGroupRow = 1;
            ac.RowSpan = 3;
            aclist[4] = ac;

            ac = new NetAction("dakai", nsd);
            //aclist = new NetAction[1];
            ac.Text = "打开";
            ac.Tag = usercontrol;
            ac.Image = Properties.Resources.open;
            ac.ActionType = NetAction.NetActionType.Edit;
            ac.DisplayStyle = 1;
            ac.Style = 1;
            ac.SetGroup = "打开";
            ac.SetGroupRow = 1;
            ac.RowSpan = 3;
            aclist[5] = ac;


            ac = new NetAction("liancha", nsd);
            //aclist = new NetAction[1];
            ac.Text = "联查询价单";
            ac.Tag = usercontrol;
            ac.Image = Properties.Resources.cost;
            ac.ActionType = NetAction.NetActionType.Edit;
            ac.DisplayStyle = 1;
            ac.Style = 1;
            ac.SetGroup = "联查询价单";
            ac.SetGroupRow = 1;
            ac.RowSpan = 3;
            aclist[6] = ac;
            //return aclist;



            ac = new NetAction("query", nsd);
            //aclist = new NetAction[1];
            ac.Text = "查询";
            ac.Tag = usercontrol;
            ac.Image = Properties.Resources.filter;
            ac.ActionType = NetAction.NetActionType.Edit;
            ac.DisplayStyle = 1;
            ac.Style = 1;
            ac.SetGroup = "查询";
            ac.SetGroupRow = 1;
            ac.RowSpan = 3;
            aclist[7] = ac;



            

            ac = new NetAction("savebuju", nsd);
            //aclist = new NetAction[1];
            ac.Text = "保存布局";
            ac.Tag = usercontrol;
            ac.Image = Properties.Resources.import;
            ac.ActionType = NetAction.NetActionType.Edit;
            ac.DisplayStyle = 1;
            ac.Style = 1;
            ac.SetGroup = "保存布局";
            ac.SetGroupRow = 1;
            ac.RowSpan = 1;
            aclist[8] = ac;

            ac = new NetAction("delbuju", nsd);
            //aclist = new NetAction[1];
            ac.Text = "删除布局";
            ac.Tag = usercontrol;
            ac.Image = Properties.Resources.import;
            ac.ActionType = NetAction.NetActionType.Edit;
            ac.DisplayStyle = 1;
            ac.Style = 1;
            ac.SetGroup = "保存布局";
            ac.SetGroupRow = 1;
            ac.RowSpan = 1;
            aclist[9] = ac;

            ac = new NetAction("save2", nsd);
            //aclist = new NetAction[1];
            ac.Text = "报价保存";
            ac.Tag = usercontrol;
            ac.Image = Properties.Resources.Confirm;
            ac.ActionType = NetAction.NetActionType.Edit;
            ac.DisplayStyle = 1;
            ac.Style = 1;
            ac.SetGroup = "报价保存";
            ac.SetGroupRow = 1;
            ac.RowSpan = 3;
            aclist[10] = ac;


            ac = new NetAction("xunjia2", nsd);
            //aclist = new NetAction[1];
            ac.Text = "研发询价";
            ac.Tag = usercontrol;
            ac.Image = Properties.Resources.query;
            ac.ActionType = NetAction.NetActionType.Edit;
            ac.DisplayStyle = 1;
            ac.Style = 1;
            ac.SetGroup = "研发询价";
            ac.SetGroupRow = 1;
            ac.RowSpan = 3;
            aclist[11] = ac;

            ac = new NetAction("quxiao", nsd);
            //aclist = new NetAction[1];
            ac.Text = "取消研发询价";
            ac.Tag = usercontrol;
            ac.Image = Properties.Resources.Select_all;
            ac.ActionType = NetAction.NetActionType.Edit;
            ac.DisplayStyle = 1;
            ac.Style = 1;
            ac.SetGroup = "研发询价";
            ac.SetGroupRow = 1;
            ac.RowSpan = 3;
            aclist[12] = ac;


            ac = new NetAction("querykc", nsd);
            //aclist = new NetAction[1];
            ac.Text = "查询库存";
            ac.Tag = usercontrol;
            ac.Image = Properties.Resources.query;
            ac.ActionType = NetAction.NetActionType.Edit;
            ac.DisplayStyle = 1;
            ac.Style = 1;
            ac.SetGroup = "查询";
            ac.SetGroupRow = 1;
            ac.RowSpan = 3;
            aclist[13] = ac;

            ac = new NetAction("xiazai", nsd);
            //aclist = new NetAction[1];
            ac.Text = "下载附件";
            ac.Tag = usercontrol;
            ac.Image = Properties.Resources.save;
            ac.ActionType = NetAction.NetActionType.Edit;
            ac.DisplayStyle = 1;
            ac.Style = 1;
            ac.SetGroup = "查询";
            ac.SetGroupRow = 1;
            //if (canshu.userName.Contains("陆茜") || canshu.userName.Contains("匡逸") || canshu.userName.Contains("demo"))
            //{
            //    ac.IsVisible = true;
            //}
            //else
            //{

                ac.IsVisible = false;
            //}
            ac.RowSpan = 3;
            aclist[14] = ac;


            ac = new NetAction("daoru", nsd);
            //aclist = new NetAction[1];
            ac.Text = "Excel导入";
            ac.Tag = usercontrol;
            ac.Image = Properties.Resources.import;
            ac.ActionType = NetAction.NetActionType.Edit;
            ac.DisplayStyle = 1;
            ac.Style = 1;
            ac.SetGroup = "导入";
            ac.SetGroupRow = 1;
            //ac.IsVisible = false;
            ac.RowSpan = 3;
            aclist[15] = ac;
            return aclist;
            ////return null;
        }
        public bool CloseEvent()
        {
            //throw new Exception("The method or operation is not implemented.");
            return true;
        }
        #endregion



        IEditorInput INetUserControl.EditorInput
        {
            get;
            set;
        }

        IEditorPart INetUserControl.EditorPart
        {
            get;set;

        }

        string INetUserControl.Title
        {
            get
            {
                return this._title;
            }
            set
            {
                this._title = value;
            }
        }
       


    }


}
