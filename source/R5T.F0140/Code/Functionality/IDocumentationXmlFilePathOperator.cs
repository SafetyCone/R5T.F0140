using System;
using System.Linq;

using R5T.T0132;
using R5T.T0172;
using R5T.T0172.Extensions;
using R5T.T0180;


namespace R5T.F0140
{
    /// <summary>
    /// .NET XML documentation file path related operator.
    /// </summary>
    [FunctionalityMarker]
    public partial interface IDocumentationXmlFilePathOperator : IFunctionalityMarker
    {
        /// <summary>
        /// Given a directory path, get all child XML file paths, and assume that all XML files are documentation files.
        /// </summary>
        public IDocumentationXmlFilePath[] Get_DocumentationXmlFilePaths_AssumeAllXmls(
            IDirectoryPath directoryPath)
        {
            // Assumes that all XML files in the directory are documentation files.
            var output = Instances.FileSystemOperator.Enumerate_ChildFilePaths(
                directoryPath,
                Instances.FileExtensions.Xml)
                .Select(x => x.Value.ToDocumentationXmlFilePath())
                .ToArray();

            return output;
        }
    }
}
