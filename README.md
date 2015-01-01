http://stackoverflow.com/questions/27729599

Integrating the WebForms ReportViewer control in RDLC (Local) mode, into an MVC project via Session and using an embedded IFrame 
in the MVC View

 - Assumes a reasonable small amount of data for the Report. 
   If there is a much larger data set, then instead of fetching the data in the MVC Controller and passing it in Session, 
   would recommend instead to pass the PARAMETERs in Session and then acquire the data from the WebForms aspx.cs code behind.
  
