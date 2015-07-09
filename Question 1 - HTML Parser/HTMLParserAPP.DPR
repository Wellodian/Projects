program HTMLParserAPP;

uses
  Forms,
  HTMLParserForm in 'HTMLParserForm.PAS' {frmHTMLParserForm},
  ABOUT in 'ABOUT.PAS' {AboutBox},
  HTMLParser in 'HTMLParser.pas';

{$R *.RES}

begin
  Application.Initialize;
  Application.CreateForm(TfrmHTMLParserForm, frmHTMLParserForm);
  Application.CreateForm(TAboutBox, AboutBox);
  Application.Run;
end.
 
