using System;
using System.Collections.Generic;
using System.Text;

namespace FirewallProxyDesignPattern
{
    public class DocumentProxy : IDocument
    {
        private Document _document;
        private string _employeeAccessLevel;
        public DocumentProxy(string content, string sensitivity, string employeeAccessLevel)
        {
            _document = new Document(content, sensitivity);
            _employeeAccessLevel = employeeAccessLevel;
        }

        public string ReadContent()
        {
            if(CanAccessDocument())
            {
                return _document.ReadContent();
            }
            else
            {
                return "Access Denied!";
            }
        }

        public bool CanAccessDocument()
        {
            switch (_document.Sensitivity)
            {
                case "Public":
                    return true;
                case "Confidential":
                    return (_employeeAccessLevel == "Manager" || _employeeAccessLevel == "Executive");
                case "Top-Secret":
                    return (_employeeAccessLevel == "Executive");
                default:
                    return false;
            }
        }
    }
}
