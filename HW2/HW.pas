unit HW;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, ComCtrls, StdCtrls, Buttons, jpeg, ExtCtrls, Menus;

type
  TForm2 = class(TForm)
    Edit1: TEdit;
    Edit2: TEdit;
    Edit3: TEdit;
    ProgressBar1: TProgressBar;
    ProgressBar2: TProgressBar;
    ProgressBar3: TProgressBar;
    SpeedButton1: TSpeedButton;
    Image1: TImage;
    Image2: TImage;
    Image3: TImage;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    MainMenu1: TMainMenu;
    N1: TMenuItem;
    N2: TMenuItem;
    SpeedButton2: TSpeedButton;
    procedure SpeedButton1Click(Sender: TObject);
    procedure Edit1KeyPress(Sender: TObject; var Key: Char);
    procedure Edit2KeyPress(Sender: TObject; var Key: Char);
    procedure Edit3KeyPress(Sender: TObject; var Key: Char);
    procedure N2Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form2: TForm2;

implementation

{$R *.dfm}

procedure TForm2.Edit1KeyPress(Sender: TObject; var Key: Char);
begin
  if not(Key in ['0'..'9']) then Key:=#0;
end;

procedure TForm2.Edit2KeyPress(Sender: TObject; var Key: Char);
begin
  if not(Key in ['0'..'9']) then Key:=#0;
end;

procedure TForm2.Edit3KeyPress(Sender: TObject; var Key: Char);
begin
  if not(Key in ['0'..'9']) then Key:=#0;
end;

procedure TForm2.N2Click(Sender: TObject);
begin
  Form2.Close;
end;

procedure TForm2.SpeedButton1Click(Sender: TObject);
var i:integer;
    win:double;
    winner:string;
    yes,dont_yes:string;
begin
  if Edit1.Text='' then Edit1.Text:='0';
  if Edit2.Text='' then Edit2.Text:='0';
  if Edit3.Text='' then Edit3.Text:='0';
  ProgressBar1.Position:=0;
  ProgressBar2.Position:=0;
  ProgressBar3.Position:=0;
  while (ProgressBar1.Position<100) and (ProgressBar2.Position<100) and (ProgressBar3.Position<100) do
  begin
    Sleep(100);
    ProgressBar1.Position:=ProgressBar1.Position+Random(2);
    ProgressBar2.Position:=ProgressBar2.Position+Random(2);
    ProgressBar3.Position:=ProgressBar3.Position+Random(2);
  end;
  //выйгрыш
  if ProgressBar1.Position=100 then
  begin
     win:= (StrToInt(Edit1.Text)-StrToInt(Edit1.Text)*0.1)*3;
     winner:=Label1.Caption;
  end;
  if ProgressBar2.Position=100 then
  begin
     win:= (StrToInt(Edit2.Text)-StrToInt(Edit2.Text)*0.1)*3;
     winner:=Label2.Caption;
  end;
  if ProgressBar3.Position=100 then
  begin
     win:= (StrToInt(Edit3.Text)-StrToInt(Edit1.Text)*0.1)*3;
     winner:=Label3.Caption;
  end;
  yes:='Выйграл таракаш '+ winner +#13#10#13#10+ 'Ваш выйгрыш составляет ' + FloatToStr(win) + ' рублей';
  dont_yes:= 'Выйграл таракаш ' + winner +#13#10+'Сожалеем, но вы ничего не выйграли';
  //1
  if (ProgressBar1.Position=100) and (StrToInt(Edit1.Text)<>0) then
    MessageDlg(yes, mtInformation, [mbOK], 0 )
  else
    if (ProgressBar1.Position=100) and (StrToInt(Edit1.Text)=0) then MessageDlg(dont_yes, mtInformation, [mbOK], 0 );
  //2
  if (ProgressBar2.Position=100) and (StrToInt(Edit2.Text)<>0) then
    MessageDlg(yes, mtInformation, [mbOK], 0 )
  else
    if (ProgressBar2.Position=100) and (StrToInt(Edit2.Text)=0) then MessageDlg(dont_yes, mtInformation, [mbOK], 0 );
  //3
  if (ProgressBar3.Position=100) and (StrToInt(Edit3.Text)<>0) then
    MessageDlg(yes, mtInformation, [mbOK], 0 )
  else
    if (ProgressBar3.Position=100) and (StrToInt(Edit1.Text)=0) then MessageDlg(dont_yes, mtInformation, [mbOK], 0 );
end;

end.
