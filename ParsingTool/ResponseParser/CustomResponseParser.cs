using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using bitb.Business.Objects.Entity;
using bitb.Parser.Base;
using ParsingTool.ExtensionMethods;

namespace ParsingTool.ResponseParser
{
    public enum TypeLookup
    {
        Loopback = 1,
        GigabitEthernet = 10,
        EtherSVI = 10,
        Ethernet = 40,
        Port_Channel = 80
    }

    public class CustomResponseParser : ParserBase
    {
        public override bool IsCdpEnabled(string response)
        {
            throw new NotImplementedException();
        }

        public override List<CdpCacheEntry> ParseCdpCacheEntryResponse(string response, string physicalContext = null, string logicalContext = null)
        {
            throw new NotImplementedException();
        }

        public override CdpGlobal ParseCdpGlobalResponse(string response, string physicalContext = null, string logicalContext = null)
        {
            throw new NotImplementedException();
        }

        public override Device ParseDeviceResponse(string response, string secondaryResponse = null, string tertiaryResponse = null)
        {
            throw new NotImplementedException();
        }

        public override List<Dot1dTpFdbEntry> ParseDot1dTpFdbEntryResponse(string response, string physicalContext = null, string logicalContext = null)
        {
            throw new NotImplementedException();
        }

        public override List<EntLogicalEntry> ParseEntityLogicalResponse(string response, string physicalContext = null, string logicalContext = null)
        {
            throw new NotImplementedException();
        }

        public override List<DeviceInterface> ParseInterfaceResponse(string response, string physicalContext = null, string logicalContext = null)
        {
            List<DeviceInterface> lstInterfaceLocalValues = new List<DeviceInterface>();
            var Paragraphs = response.Split(new string[] { "\r\n\r\n" },StringSplitOptions.None).ToList();
            for (int i = 0; i < Paragraphs.Count(); i++)
            {
                DeviceInterface deviceInterface = new DeviceInterface();
                var Sentences = Paragraphs[i].Trim().Split(new string[] { Environment.NewLine }, StringSplitOptions.None).ToList();

                var IsUp = Sentences.FirstOrDefault(x => x.Contains("is up"));
                var IsDown = Sentences.FirstOrDefault(x => x.Contains("is down"));

                if(!String.IsNullOrEmpty(IsUp))
                    deviceInterface.IfDescr = IsUp.Trim().Split(' ')[0];
                else
                    deviceInterface.IfDescr = IsDown.Trim().Split(' ')[0];

                var AddressIs = Sentences.FirstOrDefault(x => x.Contains("address is"));
                if(!String.IsNullOrEmpty(AddressIs))
                    deviceInterface.IfPhysAddress = AddressIs.Trim().Split(' ')[AddressIs.Trim().Split(' ').Length - 1];

                var Address = Sentences.FirstOrDefault(x => x.Contains("address:"));
                if (!String.IsNullOrEmpty(Address))
                    deviceInterface.IfPhysAddress = Address.Trim().Split(':')[2].Split(' ')[1];

                var MTU = Sentences.FirstOrDefault(x => x.Contains("MTU"));
                if(!String.IsNullOrEmpty(MTU))
                {
                    var mtu = MTU.Split(',')[0].Trim();
                    var bw = MTU.Split(',')[1].Trim();
                    deviceInterface.IfMtu = Convert.ToInt32(mtu.Split(' ')[1]);
                    if (bw.Split(' ')[2].Equals("kbit", StringComparison.OrdinalIgnoreCase))
                    {
                        deviceInterface.IfSpeed = (Convert.ToDecimal(bw.Split(' ')[1]) * 1000);
                    }
                    else if (bw.Split(' ')[2].Equals("mbit", StringComparison.OrdinalIgnoreCase))
                    {
                        deviceInterface.IfSpeed = (Convert.ToDecimal(bw.Split(' ')[1]) * 1000000);
                    }
                    else if (bw.Split(' ')[2].Equals("gbit", StringComparison.OrdinalIgnoreCase))
                    {
                        deviceInterface.IfSpeed = (Convert.ToDecimal(bw.Split(' ')[1]) * 1000000000);
                    }
                }

                var LoopBack = Sentences.FirstOrDefault(x => x.Contains("Loopback"));
                var Gigabit = Sentences.FirstOrDefault(x => x.Contains("GigabitEthernet"));
                var ESVI = Sentences.FirstOrDefault(x => x.Contains("EtherSVI"));
                var Ethernet = Sentences.FirstOrDefault(x => x.Contains("40000 Ethernet"));
                var PortChannel = Sentences.FirstOrDefault(x => x.Contains("Port-Channel"));
                if (!String.IsNullOrEmpty(LoopBack))
                    deviceInterface.IfType = (int)TypeLookup.Loopback;

                if (!String.IsNullOrEmpty(Gigabit))
                    deviceInterface.IfType = (int)TypeLookup.GigabitEthernet;

                if (!String.IsNullOrEmpty(ESVI))
                    deviceInterface.IfType = (int)TypeLookup.EtherSVI;

                if (!String.IsNullOrEmpty(Ethernet))
                    deviceInterface.IfType = (int)TypeLookup.Ethernet;

                if (!String.IsNullOrEmpty(PortChannel))
                    deviceInterface.IfType = (int)TypeLookup.Port_Channel;

                lstInterfaceLocalValues.Add(deviceInterface);
            }            
            return lstInterfaceLocalValues;
        }     

        public override List<IpAddrTable> ParseIpAddrTableResponse(string response, string failoverResponse, string physicalContext = null, string logicalContext = null)
        {
            throw new NotImplementedException();
        }

        public override List<IpNetToMediaEntry> ParseIpNetToMediaEntryResponse(string response, string physicalContext = null, string logicalContext = null)
        {
            throw new NotImplementedException();
        }

        public override List<IpRouteEntry> ParseIPRouteEntryResponse(string response, string physicalContext = null, string logicalContext = null)
        {
            throw new NotImplementedException();
        }

        public override LocalSystem ParseLocalSystemResponse(string response, string physicalContext = null, string logicalContext = null)
        {
            throw new NotImplementedException();
        }

        public override MemoryPool ParseMemoryPoolResponse(string response, string physicalContext = null, string logicalContext = null)
        {
            throw new NotImplementedException();
        }
    }
}
