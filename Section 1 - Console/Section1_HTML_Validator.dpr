program Section1_HTML_Validator;

{$APPTYPE CONSOLE}

uses
  SysUtils,
  HTMLValidator in 'HTMLValidator.pas';

begin
  try
    { TODO -oUser -cConsole Main : Insert code here }
  except
    on E:Exception do
      Writeln(E.Classname, ': ', E.Message);
  end;
end.
