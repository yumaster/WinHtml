using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinHtml
{
    public partial class Master : Form
    {
        /// <summary>
        /// Chromium浏览器实例
        /// </summary>
        ChromiumWebBrowser WebBrowser;
        public Master()
        {
            InitializeComponent();

            ///设置
            var setting = new CefSettings();
            setting.Locale = "zh-CN";
            setting.CachePath = Application.StartupPath + "/CHBrowser/BrowserCache";//缓存路径
            setting.AcceptLanguageList = "zh-CN,zh;q=0.8";//浏览器引擎的语言
            setting.LocalesDirPath = Application.StartupPath + "/CHBrowser/localeDir";//日志
            setting.LogFile = Application.StartupPath + "/CHBrowser/LogData";//日志文件
            setting.PersistSessionCookies = true;//
            setting.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36";//浏览器内核
            setting.UserDataPath = Application.StartupPath + "/CHBrowser/userData";//个人数据
            ///初始化
            CefSharp.Cef.Initialize(setting);
            WebBrowser = new ChromiumWebBrowser("http://www.baidu.com");//初始化实例
            WebBrowser.MenuHandler = new MenuHandler();
            CefSharpSettings.WcfEnabled = true;
            WebBrowser.RegisterJsObject("jsObj", new JsEvent(), new CefSharp.BindingOptions() { CamelCaseJavascriptNames = false }); //交互数据
            WebBrowser.Dock = DockStyle.Fill;//铺满                                                                  
            WebBrowser.Dock = DockStyle.Fill;//设置停靠方式
            this.Controls.Add(WebBrowser);//加入窗体
        }
        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            WebBrowser.Load(txt_urlpath.Text);//浏览网址
        }
        /// <summary>
        /// JS交互
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_check_Click(object sender, EventArgs e)
        {
            await WebBrowser.GetBrowser().MainFrame.EvaluateScriptAsync("test_val=" + new Random().Next().ToString("F")); //设置页面上js的test_val变量为随机数
            await WebBrowser.GetBrowser().MainFrame.EvaluateScriptAsync("test()");//运行页面上js的test方法
        }
        /// <summary>
        /// JS带参数交互
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_checkAndPara_Click(object sender, EventArgs e)
        {
            await WebBrowser.GetBrowser().MainFrame.EvaluateScriptAsync("testArg('123','我是NET' )");//运行页面上js的testArg带参数的方法
        }
    }
    /// <summary>
    /// JS事件
    /// </summary>
    public class JsEvent
    {
        public string MessageText { get; set; }
        public void ShowTest()
        {
            MessageBox.Show("进入WINFORM客户端\n\r" + MessageText);
        }
        public void ShowTestArg(string ss)
        {
            MessageBox.Show("收到JS带参数调用\n\r" + ss);
        }
    }

    #region 禁用右键菜单
    /// <summary>
    /// cef菜单事件
    /// </summary>
    public class MenuHandler : CefSharp.IContextMenuHandler
    {
        void CefSharp.IContextMenuHandler.OnBeforeContextMenu(CefSharp.IWebBrowser browserControl, CefSharp.IBrowser browser, CefSharp.IFrame frame, CefSharp.IContextMenuParams parameters, CefSharp.IMenuModel model)
        {
            model.Clear();
        }
        bool CefSharp.IContextMenuHandler.OnContextMenuCommand(CefSharp.IWebBrowser browserControl, CefSharp.IBrowser browser, CefSharp.IFrame frame, CefSharp.IContextMenuParams parameters, CefSharp.CefMenuCommand commandId, CefSharp.CefEventFlags eventFlags)
        {
            //throw new NotImplementedException();
            return false;
        }
        void CefSharp.IContextMenuHandler.OnContextMenuDismissed(CefSharp.IWebBrowser browserControl, CefSharp.IBrowser browser, CefSharp.IFrame frame)
        {
            //throw new NotImplementedException();
        }
        bool CefSharp.IContextMenuHandler.RunContextMenu(CefSharp.IWebBrowser browserControl, CefSharp.IBrowser browser, CefSharp.IFrame frame, CefSharp.IContextMenuParams parameters, CefSharp.IMenuModel model, CefSharp.IRunContextMenuCallback callback)
        {
            return false;
        }
    }
    #endregion
}
