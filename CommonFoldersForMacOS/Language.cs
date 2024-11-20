using System.Globalization;

namespace CommonFoldersForMacOS;

public static class Language
{
    public static string[] Get()
    {
        return CultureInfo.CurrentUICulture.Name switch
        {
            "zh-CN" => [
                "MacOS 常用文件夹",
                "用户", "图片", "文档", "下载", "音乐", "视频", "桌面", "应用程序"],
            _ => [
                "Common Folders For MacOS",
                "Home", "Pictures", "Documents", "Downloads", "Music", "Movies", "Desktop", "Applications"]
        };
    }
}