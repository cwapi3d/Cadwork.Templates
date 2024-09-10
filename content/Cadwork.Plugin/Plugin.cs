using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Cadwork.Plugin;

public static class Plugin
{
  [SupportedOSPlatform("windows")]
  [UnmanagedCallersOnly(EntryPoint = "plugin_x64_init")]
  public static bool InitializePlugin(IntPtr factory)
  {
    return true;
  }

  [UnmanagedCallersOnly(EntryPoint = "get_min_version_major")]
  public static uint MinimumMajorVersion()
  {
    return 30;
  }

  [UnmanagedCallersOnly(EntryPoint = "get_min_version_minor")]
  public static uint MinimumMinorVersion()
  {
    return 573;
  }

  [UnmanagedCallersOnly(EntryPoint = "get_plugin_name")]
  public static IntPtr PluginName()
  {
    return Marshal.StringToHGlobalUni("Plugin");
  }

  [UnmanagedCallersOnly(EntryPoint = "get_contact_name")]
  public static IntPtr ContactName()
  {
    return Marshal.StringToHGlobalUni("FillMe");
  }

  [UnmanagedCallersOnly(EntryPoint = "get_contact_email")]
  public static IntPtr ContactEmail()
  {
    return Marshal.StringToHGlobalUni("fill@me");
  }
}
