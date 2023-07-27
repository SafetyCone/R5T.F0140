using System;


namespace R5T.F0140
{
    public class DocumentationXmlFilePathOperator : IDocumentationXmlFilePathOperator
    {
        #region Infrastructure

        public static IDocumentationXmlFilePathOperator Instance { get; } = new DocumentationXmlFilePathOperator();


        private DocumentationXmlFilePathOperator()
        {
        }

        #endregion
    }
}
