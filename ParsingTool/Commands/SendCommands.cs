using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingTool.Commands
{
    public static class CiscoSendCommands
    {
        public static readonly string CISCO_SHOWVERSION = "show version";
        public static readonly string CISCO_SHOWINTERFACE = "show interface";
        public static readonly string CISCO_SHOWRUNNINGCONFIG = "show running-config";
        //public static readonly string CISCO_SHOWIPARP = "show ip arp";

        public static readonly string CISCO_SHOWARP = "show arp";

        public static readonly string CISCO_SHOWROUTE = "show route";

        public static readonly string CISCO_SHOWIPROUTE = "show ip route";
        public static readonly string CISCO_SHOWVLAN = "show vlan";
        public static readonly string CISCO_SHOWCDP_GLOBAL = "show cdp";
        public static readonly string CISCO_SHOWCDP_CACHEENTRY = "show cdp neighbor detail";
        public static readonly string CISCO_SHOWCONTEXT = "show context";
        public static readonly string CISCO_SHOWCONTEXT_DETAIL = "show context detail";

        public static readonly string CISCO_SHOWFAILOVER = "show failover";

        public static readonly string CISCO_SHOWMACADDRESSTABLEDYNAMIC = "show switch mac-address-table | i dynamic"; // show mac address-table dynamic";


        public static readonly string CISCO_CHANGETO_CONTEXT = "changeto context";

        public static readonly string CISCO_SHOWLOCALSYSTEM = "show processes cpu";
        public static readonly string CISCO_SHOWMEMORY = "show processes cpu";


        public static readonly string CHANGETO_SYSTEM = "changeto system";


    }

    public static class FileKeyWord
    {
        public static readonly string SECURITY_CONTEXT_CONFIGURED = "Security context configured";
    }

}
