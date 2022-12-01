using TLMSuite.decoder;
using System.Collections;

namespace greencube_decoder
{
    public class greencube_decoder_plugin : TLMSuite.decoder.IPlugin
    {
		public int Version
		{ 
			get {
				return 1;
				} 
		}

		public string Author
        {
			get
            {
				return "Tom - ZR6TG";
            }
        }

		public string Name
		{
			get
			{
				return "Greencube Telemetry Decoder";
			}
		}

		public int NoradID
		{
			get
			{
				return 53106;
			}
		}

		public string Description
        {
			get
            {
				return "A decoder pluging for Greencube from S5Labs. Satellite info can be found here: https://www.s5lab.space/index.php/greencube-home/.\n\nSoundmodem available here: http://uz7.ho.ua/greentnc.zip";
			}
        }


		public Hashtable parseFrame(byte[] frame)
        {
			Hashtable parsedData = new Hashtable();

            Greencube tlmtest = new Greencube(new Kaitai.KaitaiStream(frame));

			if (tlmtest != null)
            {
				if ( tlmtest.GreencubeRawFrame != null )
                {
					// maybe we can automate a bit more here using reflection
					parsedData.Add("UnixTimeMs", tlmtest.GreencubeRawFrame.TlmData.UnixTimeMs);
					parsedData.Add("UnixTime", tlmtest.GreencubeRawFrame.TlmData.UnixTime);
					parsedData.Add("ProcessTime", tlmtest.GreencubeRawFrame.TlmData.ProcessTime);
					parsedData.Add("SolarXVoltage", tlmtest.GreencubeRawFrame.TlmData.SolarXVoltage);
					parsedData.Add("SolarYVoltage", tlmtest.GreencubeRawFrame.TlmData.SolarYVoltage);
					parsedData.Add("SolarXCurrent", tlmtest.GreencubeRawFrame.TlmData.SolarXCurrent);
					parsedData.Add("SolarYCurrent", tlmtest.GreencubeRawFrame.TlmData.SolarYCurrent);
					parsedData.Add("EpsBootcause", tlmtest.GreencubeRawFrame.TlmData.EpsBootcause);
					parsedData.Add("EpsTemperature", tlmtest.GreencubeRawFrame.TlmData.EpsTemperature);
					parsedData.Add("Battery1Temperature", tlmtest.GreencubeRawFrame.TlmData.Battery1Temperature);
					parsedData.Add("Battery2Temperature", tlmtest.GreencubeRawFrame.TlmData.Battery2Temperature);
					parsedData.Add("Battery3Temperature", tlmtest.GreencubeRawFrame.TlmData.Battery3Temperature);
					parsedData.Add("SolarTotalCurrent", tlmtest.GreencubeRawFrame.TlmData.SolarTotalCurrent);
					parsedData.Add("SystemTotalCurrent", tlmtest.GreencubeRawFrame.TlmData.SystemTotalCurrent);
					parsedData.Add("BatteryVoltage", tlmtest.GreencubeRawFrame.TlmData.BatteryVoltage);
					parsedData.Add("EpsOutputs", tlmtest.GreencubeRawFrame.TlmData.EpsOutputs);
					parsedData.Add("RadioPaTemperature", tlmtest.GreencubeRawFrame.TlmData.RadioPaTemperature);
					parsedData.Add("RadioTxCount", tlmtest.GreencubeRawFrame.TlmData.RadioTxCount);
					parsedData.Add("RadioRxCount", tlmtest.GreencubeRawFrame.TlmData.RadioRxCount);
					parsedData.Add("RadioLastRssi", tlmtest.GreencubeRawFrame.TlmData.RadioLastRssi);
					parsedData.Add("ObcBootCount", tlmtest.GreencubeRawFrame.TlmData.ObcBootCount);
					parsedData.Add("RadioBootCount", tlmtest.GreencubeRawFrame.TlmData.RadioBootCount);
					parsedData.Add("EpsBootCount ", tlmtest.GreencubeRawFrame.TlmData.EpsBootCount);
					parsedData.Add("PayloadRxCount", tlmtest.GreencubeRawFrame.TlmData.PayloadRxCount);
					parsedData.Add("PayloadTxCount", tlmtest.GreencubeRawFrame.TlmData.PayloadTxCount);
					parsedData.Add("SoftwareStatus", tlmtest.GreencubeRawFrame.TlmData.SoftwareStatus);
					parsedData.Add("HeaterStatus", tlmtest.GreencubeRawFrame.TlmData.HeaterStatus);
					parsedData.Add("ObcTemperature", tlmtest.GreencubeRawFrame.TlmData.ObcTemperature);
					parsedData.Add("GyroscopeX", tlmtest.GreencubeRawFrame.TlmData.GyroscopeX);
					parsedData.Add("GyroscopeY", tlmtest.GreencubeRawFrame.TlmData.GyroscopeY);
					parsedData.Add("GyroscopeZ", tlmtest.GreencubeRawFrame.TlmData.GyroscopeZ);
					parsedData.Add("MagnetometerX", tlmtest.GreencubeRawFrame.TlmData.MagnetometerX);
					parsedData.Add("MagnetometerY", tlmtest.GreencubeRawFrame.TlmData.MagnetometerY);
					parsedData.Add("MagnetometerZ", tlmtest.GreencubeRawFrame.TlmData.MagnetometerZ);
					parsedData.Add("SolarpanelPlusXTemperature", tlmtest.GreencubeRawFrame.TlmData.SolarpanelPlusXTemperature);
					parsedData.Add("SolarpanelPlusYTemperature", tlmtest.GreencubeRawFrame.TlmData.SolarpanelPlusYTemperature);
					parsedData.Add("SolarpanelMinusXTemperature", tlmtest.GreencubeRawFrame.TlmData.SolarpanelMinusXTemperature);
					parsedData.Add("SolarpanelMinusYTemperature", tlmtest.GreencubeRawFrame.TlmData.SolarpanelMinusYTemperature);
					parsedData.Add("CoarseSunSensorPlusX", tlmtest.GreencubeRawFrame.TlmData.CoarseSunSensorPlusX);
					parsedData.Add("CoarseSunSensorPlusY", tlmtest.GreencubeRawFrame.TlmData.CoarseSunSensorPlusY);
					parsedData.Add("CoarseSunSensorMinusX", tlmtest.GreencubeRawFrame.TlmData.CoarseSunSensorMinusX);
					parsedData.Add("CoarseSunSensorMinusY", tlmtest.GreencubeRawFrame.TlmData.CoarseSunSensorMinusY);
					parsedData.Add("GpsStatusFlag", tlmtest.GreencubeRawFrame.TlmData.GpsStatusFlag);
					parsedData.Add("GpsFixTime", tlmtest.GreencubeRawFrame.TlmData.GpsFixTime);
					parsedData.Add("GpsLatitude", tlmtest.GreencubeRawFrame.TlmData.GpsLatitude);
					parsedData.Add("GpsLongitude", tlmtest.GreencubeRawFrame.TlmData.GpsLongitude);
					parsedData.Add("GpsAltitude", tlmtest.GreencubeRawFrame.TlmData.GpsAltitude);
					parsedData.Add("SbandTxCount", tlmtest.GreencubeRawFrame.TlmData.SbandTxCount);
					parsedData.Add("AntennaStatusFlag", tlmtest.GreencubeRawFrame.TlmData.AntennaStatusFlag);
					parsedData.Add("AcsStateFlag", tlmtest.GreencubeRawFrame.TlmData.AcsStateFlag);
					parsedData.Add("AcsParametersFlag", tlmtest.GreencubeRawFrame.TlmData.AcsParametersFlag);

				}

			}

			return parsedData;
        }
	}
}