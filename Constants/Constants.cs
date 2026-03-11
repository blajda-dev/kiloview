using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;

namespace Kiloview.Constants
{
    public class Result
    {
        public const string Ok = "ok";
        public const string Error = "error";
        public const string VerificationError = "verficationError";
    }

    public class Language
    {
        public const string English = "en";
        public const string Chinese = "zh";
    }

    public class URI
    {
        //api
        private const string API = "/api";
        
        //services
        private const string SystemCtrl      = "/systemctrl";
        private const string CodecCtrl       = "/codec";

        //login control
        public const string UserLogin       = API + SystemCtrl + Service.Users + ServiceEndpoints.Login;
        public const string UserSession     = API + SystemCtrl + Service.Users + ServiceEndpoints.Session;

        //system control
        public const string SystemInformation = API + SystemCtrl + Service.System + ServiceEndpoints.GetSystemInformation;

        //codec decoder control
        public const string CodecDecodingStreamInfo     = API + CodecCtrl + Service.Decode + ServiceEndpoints.Get;
        public const string CodecDecoderPresetListInfo  = API + CodecCtrl + Service.Preset + ServiceEndpoints.Get;
        public const string CodecDecoderPresetSelect    = API + CodecCtrl + Service.Decode + ServiceEndpoints.Add;

    }

    public static class Service
    {
        internal const string Discovery = "/discovery";
        internal const string Preset = "/preset";
        internal const string Decode = "/decode";
        internal const string Encode = "/encode";
        internal const string Mode = "/mode";
        internal const string Users = "/users";
        internal const string System = "/system";
    }

    public static class ServiceEndpoints
    {
        public const string Login = "/login";
        public const string Session = "/session";
        public const string Get = "/get";
        public const string List = "/list";
        public const string Add = "/add";
        public const string Remove = "/remove";
        public const string Modify = "/modify";
        public const string SetLocation = "/setLocation";
        public const string SetTime = "/setTime";
        public const string Components = "/components";
        public const string GetHostname = "/getHostname";
        public const string GetProtocol = "/getProtocol";
        public const string SetProtocol = "/setProtocol";
        public const string FactoryReset = "/reFactory";
        public const string Restore = "/restore";
        public const string Reboot = "/reboot";
        public const string GetNetworkSpeed = "/getNetworkSpeed";
        public const string GetSystemInformation = "/getSystemInfo";
        public const string SetOutputDecoding = "/output_set";
        public const string SetNDIConnection = "/setConnection";
        public const string SetDiscoveryServer = "/setDiscoveryServer";
        public const string GetDiscoveryServer = "/getDiscoveryServer";
        public const string Scan = "/scan";
        public const string SelectDecodingStream = "/addSpec";
    }

    public static class Methods
    {
        public const string Login = ServiceEndpoints.Login;
        public const string Session = ServiceEndpoints.Session;
        public const string GetPresetListInformation = Service.Preset + ServiceEndpoints.Get;
        public const string GetDecodingStreamInformation = Service.Decode + ServiceEndpoints.Get;
        public const string GetSystemInformation = Service.System + ServiceEndpoints.GetSystemInformation;
        public const string SetDecodingPreset = Service.Decode + ServiceEndpoints.Add;
    }
}