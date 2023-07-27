# R5T.F0140
.NET XML documentation file path related functionality.


## Related

* R5T.F0040 (project path related documentation file paths):
	R5T.F0040.IProjectPathsOperator.GetDocumentationFilePath_ForAssemblyFilePath(System.String assemblyFilePath);System.String
* R5T.F0099 (documentation by member identity name):
	R5T.F0099.F001.IDocumentationOperations.GetDocumentationByMemberIdentityName(System.String documentationXmlFilePath);System.Collections.Generic.Dictionary<System.String, System.String>


## TODO

* Get documentation XML file paths in a directory.
	* Is-a documentation XML file path?
		* Path only (no file-system queries):
			* Is it an XML file path?
		* File-system queries:
			* Is there a corresponding DLL file path?
		* File contents:
			* Is it XML?
			* Does it have a root <doc> element?