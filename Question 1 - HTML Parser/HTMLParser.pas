unit HTMLParser;

interface

uses
  Classes, SysUtils, Dialogs;

type
    THTMLParser = class
        private
            sResultText: string;
            sHTMLText: string;
            procedure Parse(sHTMLText: string; slOpenTags: TStringList);
        public
            constructor Create(text: string);
            procedure ParseText;
            property ResultText: string read sResultText write sResultText;
    end;

implementation

constructor THTMLParser.Create(text: string);
begin
    inherited Create;
    sHTMLText := text;
end;

procedure THTMLParser.ParseText;
var
    slOpenTags: TStringList;
begin
    slOpenTags := TStringList.Create;
    try
        Parse(sHTMLText, slOpenTags);


    finally
        slOpenTags.Free;
    end;

end;

procedure THTMLParser.Parse(sHTMLText: string; slOpenTags: TStringList);
var
    iPos: integer;
    sTag: string;
    sRemainingHTMLText: string;
begin
    iPos := Pos('<', sHTMLText);

    if (iPos > 0) then
    begin
        // check if closing tag
        if (sHTMLText[iPos + 1] = '/')
        and (sHTMLText[iPos + 2] in ['A'..'Z'])
        and (sHTMLText[iPos + 3] = '>') then
        begin
            if (slOpenTags.Count = 0) then
            begin
                sResultText := Format('Expected # found </%s>', [sHTMLText[iPos + 2]]);
                Exit;
            end
            else
            begin
                if (SameText(slOpenTags.Strings[slOpenTags.Count-1], sHTMLText[iPos + 2])) then
                begin
                    slOpenTags.Delete(slOpenTags.Count-1);
                    sRemainingHTMLText := Copy(sHTMLText, iPos + 4, Length(sHTMLText) - (iPos + 3));
                    Parse(sRemainingHTMLText, slOpenTags);
                end
                else
                begin
                    sResultText := Format('Expected </%s> found </%s>', [slOpenTags.Strings[slOpenTags.Count-1], sHTMLText[iPos + 2]]);
                    Exit;
                end;
            end;
        end
        // check if opening tag
        else if (sHTMLText[iPos + 1] in ['A'..'Z'])
        and (sHTMLText[iPos + 2] = '>') then
        begin
            slOpenTags.Add(sHTMLText[iPos + 1]);
            sRemainingHTMLText := Copy(sHTMLText, iPos + 3, Length(sHTMLText) - (iPos + 2));
            Parse(sRemainingHTMLText, slOpenTags);
        end
        else
        begin
            sRemainingHTMLText := Copy(sHTMLText, iPos + 1, Length(sHTMLText) - (iPos));
            Parse(sRemainingHTMLText, slOpenTags);
        end;
    end
    else
    begin
        if (slOpenTags.Count = 0) then
            sResultText := 'Correctly tagged paragraph'
        else
            sResultText := Format('Expected </%s> found #', [slOpenTags.Strings[slOpenTags.Count-1]]);
    end;


end;

end.