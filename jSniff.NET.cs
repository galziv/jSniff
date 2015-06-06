namespace Leverate.BX8.WebServer.Automation.Framework.Utils
{
    using System.Collections.Generic;
    using OpenQA.Selenium;

    public static class Spy
    {
        public static void Sniff(IJavaScriptExecutor executor, string func, string name, string customCode = "")
        {
            string script;

            if (!string.IsNullOrEmpty(customCode))
            {
                script = string.Format("{0} = spy.sniffify({0},'{1}','{2}');", func, name, customCode);
            }
            else
            {
                script = string.Format("{0} = spy.sniffify({0},'{1}');", func, name);
            }

            executor.ExecuteScript(script);
        }

        public static Dictionary<string, object> GetExecutionParameters(IJavaScriptExecutor executor, string name)
        {
            // changed. verify working. perhaps return is redundant.
            var extract = string.Format("return spy.getLastExecutionParams();", name);
            var paramsDictionary = executor.ExecuteScript(extract);
            return (Dictionary<string, object>)paramsDictionary;
        }
    }
}
