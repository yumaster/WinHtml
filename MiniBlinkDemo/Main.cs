using MB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniBlinkDemo
{
    public partial class Main : Form
    {
        private WebView m_wView = null;
        public Main()
        {
            InitializeComponent();
        }

        private void btn_runJsWithRet_Click(object sender, EventArgs e)
        {
            string strJs = "document.getElementById('text').innerHTML";
            object obj = m_wView.RunJS($"return {strJs}");    // 获取js代码的返回值，一定要加上return
            MessageBox.Show($"{(string)obj}", $"【我是C#对话框】{strJs}的执行结果为：", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_InvokeJsNoRet_Click(object sender, EventArgs e)
        {
            m_wView.CallJsFunc("showText");
        }

        private void btn_InvokeJsWithRet_Click(object sender, EventArgs e)
        {
            string strFuncName = "getText";
            object obj = m_wView.CallJsFunc(strFuncName, "text");

            MessageBox.Show($"{(string)obj}", $"【我是C#对话框】js返回给我的{strFuncName}函数的执行结果为：", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            m_wView = new WebView();
            m_wView.Bind(panel_bs);
            m_wView.LoadHTML(GetDemoHtml());

            m_wView.BindFunction("JsFunc1", new wkeJsNativeFunction(JsFunc1));
            m_wView.BindFunction("JsFunc2", new wkeJsNativeFunction(JsFunc2));
            m_wView.BindFunction("JsFunc3", new wkeJsNativeFunction(JsFunc3));
        }

        private long JsFunc1(IntPtr es, IntPtr param)
        {
            var args = GetArgs(es);
            MessageBox.Show($"js函数参数个数为：{args.Count}", $"【我是js调起的C#对话框】", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 0;
        }

        private long JsFunc2(IntPtr es, IntPtr param)
        {
            var args = GetArgs(es);
            MessageBox.Show($"js函数参数内容为：{(string)args[0]}", $"【我是js调起的c#对话框】", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 0;
        }

        private long JsFunc3(IntPtr es, IntPtr param)
        {
            var args = GetArgs(es);

            int iReault = 0;
            foreach (var arg in args)
            {
                iReault += Convert.ToInt32(arg);
            }

            return m_wView.ToJsValue(iReault);
        }

        private List<object> GetArgs(IntPtr es)
        {
            var args = new List<object>();
            for (var i = 0; i < MBApi.jsArgCount(es); i++)
            {
                args.Add(m_wView.ToNetValue(MBApi.jsArg(es, i)));
            }

            return args;
        }
        private string GetDemoHtml()
        {
            string strHtml = string.Join(".", typeof(Main).Namespace, "HtmlDemo.html");
            using (Stream st = typeof(Main).Assembly.GetManifestResourceStream(strHtml))
            {
                StreamReader sr = new StreamReader(st, Encoding.UTF8);
                strHtml = sr.ReadToEnd();
            }
            return strHtml;
        }
    }
}
