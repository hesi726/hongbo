rem rem ���ݵ�ǰʱ�����������nuget������Ҫɾ�����ļ�
set tempdir=e:\temp
for /f "tokens=1-3 delims=/- " %%1 in ("%date%") do set/a year=%%1,month=%%2,day=%%3
for /f "tokens=1-3 delims=/: " %%1 in ("%time%") do set/a hour=%%1,minute=%%2,second=%%3
rem �������汾ǰ����ܻ���0,����buildʱ��ȥ��ǰ������Ч0
rem rem set version=0.%date:~2,2%%date:~5,2%.%date:~8,2%%time:~0,2%.%time:~3,2%%time:~6,2%
rem 1903, 194 ��ǰǰ���0���뱣�������� 201 �İ汾��С�� 1903  (�·�֮ǰ��ǰ��0 ���뱣��)
rem ͬһ���ʱ��汾 410���ĵ�ʮ�֣�  �� 121 �� ��12���1�֣� ����Ҳ���뱣��ǰ��0��
rem �����������Ӱ汾�ź��沿�֣����� ���ڡ�Сʱ����) ���ֵ�ǰ��0���뱣����Ҳ����
rem time �������ͬ 9:03:03��ʽ,9��ʱû��ǰ���0
echo %hour:~0,1% 
if %hour:~0,1% == 0 goto next
set hour=0%hour%
set hour=%hour: =%
:next
set version=0.%year:~2,2%%date:~5,2%.%day%%hour%.%minute%%time:~6,2%
echo %version%
del %tempdir%\*  /Q
set license=http://www.gnu.org/licenses/licenses.html
set PackageProjectUrl=https://github.com/hesi726/hongbo
set RepositoryUrl=https://github.com/hesi726/hongbo/tree/master/hongbo.map/hongbo.AmapWebservice
set nupkgfile=%tempdir%
set str=%1
for /f "delims=\, tokens=6,7" %%i in (%str%) do (
   set RepositoryUrl="https://github.com/hesi726/hongbo/tree/master/%%i/%%j"
   set nupkgfile=%nupkgfile%\%%j.%version%.nupkg
   rem ���������������������ʹ�� dotnet bat ������� csproj ��Ҳ������ ProjectId �� Property �Ļ�)
   rem set PackageId=%%j
)
rem https://github.com/hesi726/hongbo/tree/master/hongbo.map/hongbo.AmapWebservice
echo %RepositoryUrl%
set PackageLicenseFile=license.txt
rem PackageLicenseFile=%PackageLicenseFile%;
rem GeneratePackageOnBuild=true;
dotnet build %1 -c Release -o %tempdir% -property:Authors=daiwei;Company=hongbo;Version=%version%;AssemblyVersion="%version%";FileVersion="%version%";Copyright="%license%";PackageProjectUrl="%PackageProjectUrl%";RepositoryUrl=%RepositoryUrl%;PackageRequireLicenseAcceptance=true
echo %nupkgfile%
dotnet nuget push %nupkgfile% -k %2 -s https://api.nuget.org/v3/index.json