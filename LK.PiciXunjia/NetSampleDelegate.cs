using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UFIDA.U8.Portal.Framework.Actions;
using System.Windows.Forms;

namespace LKU8.shoukuan
{
    class NetSampleDelegate : IActionDelegate
    {
        #region IActionDelegate 成员

        //代理，和菜单项关联。
        void IActionDelegate.Run(IAction action)
        {
            //action.tag 把实例化的 user control 传过来了。
            //使用时，直接使用 action.tag就可以了。方法要使用public，才可以用。
            UserControl1 us = (UserControl1)action.Tag;
                switch (action.Id)
                {
                    case "add":
                        {
                            us.Add();
                            return;
                        }
                    case "del":
                        {
                            us.Del();
                           
                            return;
                        }
                    case "save":
                        {
                            us.Save();
                            //us.WaitJs();
                            return;
                        }
                    case "save2":
                        {
                            us.Save2();
                            //us.WaitJs();
                            return;
                        }
                    case "xunjia":
                        {
                            us.Tijiao();

                            return;
                        }
                    case "xunjia2":
                        {
                            us.YanfaXunJia();

                            return;
                        }

                    case "guanbi":
                        {
                            us.guanbi();

                            return;
                        }
                  
                    case "liancha":
                        {
                            us.Liancha();
                               

                            return;
                        }
                    case "query":
                        {
                            us.Cx();


                            return;
                        }
                    case "savebuju":
                        {
                            us.SaveBuju();


                            return;
                        }
                    case "delbuju":
                        {
                            us.DelBuju();


                            return;
                        }
                    case "dakai":
                        {
                            us.DaKai();


                            return;
                        }
                    case "quxiao":
                        {
                            us.QuXiaoYanfa();


                            return;
                        }
                    case "querykc":
                        {
                            us.QueryKC();


                            return;
                        }
                    case "xiazai":
                        {
                            us.QuXiaoYanfa();


                            return;
                        }
                    case "daoru":
                        {
                            us.ExcelIn();


                            return;
                        }
                      
                }
                MessageBox.Show("press a Toolbar ID is '"+ action.Id+"'");
            
        }

        void IActionDelegate.SelectionChanged(IAction action, UFIDA.U8.Portal.Common.Core.ISelection selection)
        {
            //throw new NotImplementedException();
        }

        #endregion
    }
}
