using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitb.Parser.Base;

namespace ParsingTool.ResponseReader
{
    public class CustomResponseReader : ResponseBase
    {

        public CustomResponseReader(string inputFile)
         : base(inputFile)
        {

        }

        public CustomResponseReader()
        {

        }

        public override string ReadARPResponse(string userCommand = null, string vrfName = null)
        {
            throw new NotImplementedException();
        }

        public override string ReadCDPCacheEntryResponse(string userCommand = null)
        {
            throw new NotImplementedException();
        }

        public override string ReadCDPEnabledResponse()
        {
            throw new NotImplementedException();
        }

        public override string ReadCDPGlobalDataResponse(string userCommand = null)
        {
            throw new NotImplementedException();
        }

        public override string ReadChangeContextResponse(string vphysicalContextName)
        {
            throw new NotImplementedException();
        }

        public override string ReadChangeToSystemResponse()
        {
            throw new NotImplementedException();
        }

        public override string ReadChangeVDCContextResponse()
        {
            throw new NotImplementedException();
        }

        public override string ReadDeviceResponse(string userCommand = null)
        {
            throw new NotImplementedException();
        }

        public override string ReadDot1dTpFdbResponse(string userCommand = null)
        {
            throw new NotImplementedException();
        }

        public override string ReadEntityLogicalResponse(string userCommand = null)
        {
            throw new NotImplementedException();
        }

        public override string ReadFailoverResponse()
        {
            throw new NotImplementedException();
        }

        public override string ReadInterfaceResponse(string userCommand = null)
        {
            throw new NotImplementedException();
        }

        public override string ReadIPAddrResponse(string userCommand = null)
        {
            throw new NotImplementedException();
        }

        public override string ReadLocalSystemResponse(string userCommand = null)
        {
            throw new NotImplementedException();
        }

        public override string ReadMemoryResponse(string userCommand = null)
        {
            throw new NotImplementedException();
        }

        public override string ReadPriorityResponse(string userCommand = null)
        {
            throw new NotImplementedException();
        }

        public override string ReadRouteResponse(string userCommand = null, string vrfName = null)
        {
            throw new NotImplementedException();
        }

        public override string ReadSecurityContextResponse(string userCommand = null)
        {
            throw new NotImplementedException();
        }

        public override string ReadSwitchVDCContextResponse()
        {
            throw new NotImplementedException();
        }

        public override string ReadVDCReponse()
        {
            throw new NotImplementedException();
        }

        public override string ReadVLogicalResponse()
        {
            throw new NotImplementedException();
        }
    }
}
