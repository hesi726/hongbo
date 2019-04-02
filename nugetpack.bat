rem rem 根据当前时间产生并发布nuget包，不要删除此文件
set tempdir=e:\temp
for /f "tokens=1-3 delims=/- " %%1 in ("%date%") do set/a year=%%1,month=%%2,day=%%3
for /f "tokens=1-3 delims=/: " %%1 in ("%time%") do set/a hour=%%1,minute=%%2,second=%%3
rem 下面语句版本前面可能会有0,但是build时会去掉前导的无效0
rem rem set version=0.%date:~2,2%%date:~5,2%.%date:~8,2%%time:~0,2%.%time:~3,2%%time:~6,2%
rem 1903, 194 日前前面的0必须保留，否则 201 的版本号小于 1903  (月份之前的前导0 必须保留)
rem 同一天的时间版本 410（四点十分）  和 121 和 （12点过1分） 分钟也必须保留前导0；
rem 综上所述，子版本号后面部分（例如 日期、小时、秒) 部分的前导0必须保留，也即：
rem time 输出将如同 9:03:03形式,9点时没有前面的0
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
   rem 设置下面这个环境变量会使得 dotnet bat 报错（如果 csproj 中也定义了 ProjectId 的 Property 的话)
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