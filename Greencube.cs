using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kaitai;

namespace greencube_decoder
{

    /// <summary>
    /// :field header: greencube_raw_frame.csp_header.header
    /// :field priority: greencube_raw_frame.csp_header.priority
    /// :field src: greencube_raw_frame.csp_header.src
    /// :field dest: greencube_raw_frame.csp_header.dest
    /// :field dest_port: greencube_raw_frame.csp_header.dest_port
    /// :field src_port: greencube_raw_frame.csp_header.src_port
    /// :field hmac: greencube_raw_frame.csp_header.hmac
    /// :field xtea: greencube_raw_frame.csp_header.xtea
    /// :field rdp: greencube_raw_frame.csp_header.rdp
    /// :field crc: greencube_raw_frame.csp_header.crc
    /// :field tlm_id: greencube_raw_frame.tlm_id
    /// :field unix_time_ms: greencube_raw_frame.tlm_data.unix_time_ms
    /// :field unix_time: greencube_raw_frame.tlm_data.unix_time
    /// :field process_time: greencube_raw_frame.tlm_data.process_time
    /// :field solar_x_voltage: greencube_raw_frame.tlm_data.solar_x_voltage
    /// :field solar_y_voltage: greencube_raw_frame.tlm_data.solar_y_voltage
    /// :field solar_x_current: greencube_raw_frame.tlm_data.solar_x_current
    /// :field solar_y_current: greencube_raw_frame.tlm_data.solar_y_current
    /// :field eps_bootcause: greencube_raw_frame.tlm_data.eps_bootcause
    /// :field mppt_x_temperature: greencube_raw_frame.tlm_data.mppt_x_temperature
    /// :field mppt_y_temperature: greencube_raw_frame.tlm_data.mppt_y_temperature
    /// :field eps_temperature: greencube_raw_frame.tlm_data.eps_temperature
    /// :field battery_1_temperature: greencube_raw_frame.tlm_data.battery_1_temperature
    /// :field battery_2_temperature: greencube_raw_frame.tlm_data.battery_2_temperature
    /// :field battery_3_temperature: greencube_raw_frame.tlm_data.battery_3_temperature
    /// :field solar_total_current: greencube_raw_frame.tlm_data.solar_total_current
    /// :field system_total_current: greencube_raw_frame.tlm_data.system_total_current
    /// :field battery_voltage: greencube_raw_frame.tlm_data.battery_voltage
    /// :field eps_outputs: greencube_raw_frame.tlm_data.eps_outputs
    /// :field radio_pa_temperature: greencube_raw_frame.tlm_data.radio_pa_temperature
    /// :field radio_tx_count: greencube_raw_frame.tlm_data.radio_tx_count
    /// :field radio_rx_count: greencube_raw_frame.tlm_data.radio_rx_count
    /// :field radio_last_rssi: greencube_raw_frame.tlm_data.radio_last_rssi
    /// :field obc_boot_count: greencube_raw_frame.tlm_data.obc_boot_count
    /// :field radio_boot_count: greencube_raw_frame.tlm_data.radio_boot_count
    /// :field eps_boot_count: greencube_raw_frame.tlm_data.eps_boot_count
    /// :field payload_rx_count: greencube_raw_frame.tlm_data.payload_rx_count
    /// :field payload_tx_count: greencube_raw_frame.tlm_data.payload_tx_count
    /// :field software_status: greencube_raw_frame.tlm_data.software_status
    /// :field heater_status: greencube_raw_frame.tlm_data.heater_status
    /// :field obc_temperature: greencube_raw_frame.tlm_data.obc_temperature
    /// :field gyroscope_x: greencube_raw_frame.tlm_data.gyroscope_x
    /// :field gyroscope_y: greencube_raw_frame.tlm_data.gyroscope_y
    /// :field gyroscope_z: greencube_raw_frame.tlm_data.gyroscope_z
    /// :field magnetometer_x: greencube_raw_frame.tlm_data.magnetometer_x
    /// :field magnetometer_y: greencube_raw_frame.tlm_data.magnetometer_y
    /// :field magnetometer_z: greencube_raw_frame.tlm_data.magnetometer_z
    /// :field solarpanel_plus_x_temperature: greencube_raw_frame.tlm_data.solarpanel_plus_x_temperature
    /// :field solarpanel_plus_y_temperature: greencube_raw_frame.tlm_data.solarpanel_plus_y_temperature
    /// :field solarpanel_minus_x_temperature: greencube_raw_frame.tlm_data.solarpanel_minus_x_temperature
    /// :field solarpanel_minus_y_temperature: greencube_raw_frame.tlm_data.solarpanel_minus_y_temperature
    /// :field coarse_sun_sensor_plus_x: greencube_raw_frame.tlm_data.coarse_sun_sensor_plus_x
    /// :field coarse_sun_sensor_plus_y: greencube_raw_frame.tlm_data.coarse_sun_sensor_plus_y
    /// :field coarse_sun_sensor_minus_x: greencube_raw_frame.tlm_data.coarse_sun_sensor_minus_x
    /// :field coarse_sun_sensor_minus_y: greencube_raw_frame.tlm_data.coarse_sun_sensor_minus_y
    /// :field gps_status_flag: greencube_raw_frame.tlm_data.gps_status_flag
    /// :field gps_fix_time: greencube_raw_frame.tlm_data.gps_fix_time
    /// :field gps_latitude: greencube_raw_frame.tlm_data.gps_latitude
    /// :field gps_longitude: greencube_raw_frame.tlm_data.gps_longitude
    /// :field gps_altitude: greencube_raw_frame.tlm_data.gps_altitude
    /// :field sband_tx_count: greencube_raw_frame.tlm_data.sband_tx_count
    /// :field antenna_status_flag: greencube_raw_frame.tlm_data.antenna_status_flag
    /// :field acs_state_flag: greencube_raw_frame.tlm_data.acs_state_flag
    /// :field acs_parameters_flag: greencube_raw_frame.tlm_data.acs_parameters_flag
    /// </summary>
    public partial class Greencube : KaitaiStruct
    {
        public static Greencube FromFile(string fileName)
        {
            return new Greencube(new KaitaiStream(fileName));
        }

        public Greencube(KaitaiStream p__io, KaitaiStruct p__parent = null, Greencube p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            switch (M_Io.Size)
            {
                case 101:
                    {
                        _greencubeRawFrame = new GreencubeTlmFrame(m_io, this, m_root);
                        break;
                    }
            }
        }
        public partial class GreencubeTlmFrame : KaitaiStruct
        {
            public static GreencubeTlmFrame FromFile(string fileName)
            {
                return new GreencubeTlmFrame(new KaitaiStream(fileName));
            }

            public GreencubeTlmFrame(KaitaiStream p__io, Greencube p__parent = null, Greencube p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _cspHeader = new CspHeader(m_io, this, m_root);
                _tlmId = m_io.ReadU2be();
                if (!(((TlmId == 13840) || (TlmId == 13841) || (TlmId == 13842) || (TlmId == 30234))))
                {
                    throw new ValidationNotAnyOfError(TlmId, M_Io, "/types/greencube_tlm_frame/seq/1");
                }
                _tlmData = new TlmData(m_io, this, m_root);
            }
            private CspHeader _cspHeader;
            private ushort _tlmId;
            private TlmData _tlmData;
            private Greencube m_root;
            private Greencube m_parent;
            public CspHeader CspHeader { get { return _cspHeader; } }
            public ushort TlmId { get { return _tlmId; } }
            public TlmData TlmData { get { return _tlmData; } }
            public Greencube M_Root { get { return m_root; } }
            public Greencube M_Parent { get { return m_parent; } }
        }
        public partial class CspHeader : KaitaiStruct
        {
            public static CspHeader FromFile(string fileName)
            {
                return new CspHeader(new KaitaiStream(fileName));
            }

            public CspHeader(KaitaiStream p__io, Greencube.GreencubeTlmFrame p__parent = null, Greencube p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                f_src = false;
                f_dest = false;
                f_rdp = false;
                f_srcPort = false;
                f_priority = false;
                f_xtea = false;
                f_hmac = false;
                f_crc = false;
                f_destPort = false;
                _read();
            }
            private void _read()
            {
                _header = m_io.ReadU4be();
            }
            private bool f_src;
            private int _src;
            public int Src
            {
                get
                {
                    if (f_src)
                        return _src;
                    _src = (int)(((Header >> 25) & 31));
                    f_src = true;
                    return _src;
                }
            }
            private bool f_dest;
            private int _dest;
            public int Dest
            {
                get
                {
                    if (f_dest)
                        return _dest;
                    _dest = (int)(((Header >> 20) & 31));
                    f_dest = true;
                    return _dest;
                }
            }
            private bool f_rdp;
            private int _rdp;
            public int Rdp
            {
                get
                {
                    if (f_rdp)
                        return _rdp;
                    _rdp = (int)(((Header >> 1) & 1));
                    f_rdp = true;
                    return _rdp;
                }
            }
            private bool f_srcPort;
            private int _srcPort;
            public int SrcPort
            {
                get
                {
                    if (f_srcPort)
                        return _srcPort;
                    _srcPort = (int)(((Header >> 8) & 63));
                    f_srcPort = true;
                    return _srcPort;
                }
            }
            private bool f_priority;
            private int _priority;
            public int Priority
            {
                get
                {
                    if (f_priority)
                        return _priority;
                    _priority = (int)(((Header >> 30) & 3));
                    f_priority = true;
                    return _priority;
                }
            }
            private bool f_xtea;
            private int _xtea;
            public int Xtea
            {
                get
                {
                    if (f_xtea)
                        return _xtea;
                    _xtea = (int)(((Header >> 2) & 1));
                    f_xtea = true;
                    return _xtea;
                }
            }
            private bool f_hmac;
            private int _hmac;
            public int Hmac
            {
                get
                {
                    if (f_hmac)
                        return _hmac;
                    _hmac = (int)(((Header >> 3) & 1));
                    f_hmac = true;
                    return _hmac;
                }
            }
            private bool f_crc;
            private int _crc;
            public int Crc
            {
                get
                {
                    if (f_crc)
                        return _crc;
                    _crc = (int)((Header & 1));
                    f_crc = true;
                    return _crc;
                }
            }
            private bool f_destPort;
            private int _destPort;
            public int DestPort
            {
                get
                {
                    if (f_destPort)
                        return _destPort;
                    _destPort = (int)(((Header >> 14) & 63));
                    f_destPort = true;
                    return _destPort;
                }
            }
            private uint _header;
            private Greencube m_root;
            private Greencube.GreencubeTlmFrame m_parent;
            public uint Header { get { return _header; } }
            public Greencube M_Root { get { return m_root; } }
            public Greencube.GreencubeTlmFrame M_Parent { get { return m_parent; } }
        }
        public partial class TlmData : KaitaiStruct
        {
            public static TlmData FromFile(string fileName)
            {
                return new TlmData(new KaitaiStream(fileName));
            }

            public TlmData(KaitaiStream p__io, Greencube.GreencubeTlmFrame p__parent = null, Greencube p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _unixTimeMs = m_io.ReadU2be();
                _unixTime = m_io.ReadU4be();
                _processTime = m_io.ReadU2be();
                _solarXVoltage = m_io.ReadU2be();
                _solarYVoltage = m_io.ReadU2be();
                _solarXCurrent = m_io.ReadU2be();
                _solarYCurrent = m_io.ReadU2be();
                _epsBootcause = m_io.ReadU1();
                _mpptXTemperature = m_io.ReadS1();
                _mpptYTemperature = m_io.ReadS1();
                _epsTemperature = m_io.ReadS1();
                _battery1Temperature = m_io.ReadS1();
                _battery2Temperature = m_io.ReadS1();
                _battery3Temperature = m_io.ReadS1();
                _solarTotalCurrent = m_io.ReadU2be();
                _systemTotalCurrent = m_io.ReadU2be();
                _batteryVoltage = m_io.ReadU2be();
                _epsOutputs = m_io.ReadU1();
                _radioPaTemperature = m_io.ReadS1();
                _radioTxCount = m_io.ReadU2be();
                _radioRxCount = m_io.ReadU2be();
                _radioLastRssi = m_io.ReadS2be();
                _obcBootCount = m_io.ReadU2be();
                _radioBootCount = m_io.ReadU2be();
                _epsBootCount = m_io.ReadU2be();
                _payloadRxCount = m_io.ReadU1();
                _payloadTxCount = m_io.ReadU1();
                _softwareStatus = m_io.ReadU1();
                _heaterStatus = m_io.ReadU1();
                _obcTemperature = m_io.ReadU1();
                _gyroscopeX = m_io.ReadS2be();
                _gyroscopeY = m_io.ReadS2be();
                _gyroscopeZ = m_io.ReadS2be();
                _magnetometerX = m_io.ReadS2be();
                _magnetometerY = m_io.ReadS2be();
                _magnetometerZ = m_io.ReadS2be();
                _solarpanelPlusXTemperature = m_io.ReadS1();
                _solarpanelPlusYTemperature = m_io.ReadS1();
                _solarpanelMinusXTemperature = m_io.ReadS1();
                _solarpanelMinusYTemperature = m_io.ReadS1();
                _coarseSunSensorPlusX = m_io.ReadU2be();
                _coarseSunSensorPlusY = m_io.ReadU2be();
                _coarseSunSensorMinusX = m_io.ReadU2be();
                _coarseSunSensorMinusY = m_io.ReadU2be();
                _gpsStatusFlag = m_io.ReadU1();
                _gpsFixTime = m_io.ReadU4be();
                _gpsLatitude = m_io.ReadU4be();
                _gpsLongitude = m_io.ReadU4be();
                _gpsAltitude = m_io.ReadU4be();
                _sbandTxCount = m_io.ReadU2be();
                _antennaStatusFlag = m_io.ReadU2be();
                _acsStateFlag = m_io.ReadU1();
                _acsParametersFlag = m_io.ReadU1();
            }
            private ushort _unixTimeMs;
            private uint _unixTime;
            private ushort _processTime;
            private ushort _solarXVoltage;
            private ushort _solarYVoltage;
            private ushort _solarXCurrent;
            private ushort _solarYCurrent;
            private byte _epsBootcause;
            private sbyte _mpptXTemperature;
            private sbyte _mpptYTemperature;
            private sbyte _epsTemperature;
            private sbyte _battery1Temperature;
            private sbyte _battery2Temperature;
            private sbyte _battery3Temperature;
            private ushort _solarTotalCurrent;
            private ushort _systemTotalCurrent;
            private ushort _batteryVoltage;
            private byte _epsOutputs;
            private sbyte _radioPaTemperature;
            private ushort _radioTxCount;
            private ushort _radioRxCount;
            private short _radioLastRssi;
            private ushort _obcBootCount;
            private ushort _radioBootCount;
            private ushort _epsBootCount;
            private byte _payloadRxCount;
            private byte _payloadTxCount;
            private byte _softwareStatus;
            private byte _heaterStatus;
            private byte _obcTemperature;
            private short _gyroscopeX;
            private short _gyroscopeY;
            private short _gyroscopeZ;
            private short _magnetometerX;
            private short _magnetometerY;
            private short _magnetometerZ;
            private sbyte _solarpanelPlusXTemperature;
            private sbyte _solarpanelPlusYTemperature;
            private sbyte _solarpanelMinusXTemperature;
            private sbyte _solarpanelMinusYTemperature;
            private ushort _coarseSunSensorPlusX;
            private ushort _coarseSunSensorPlusY;
            private ushort _coarseSunSensorMinusX;
            private ushort _coarseSunSensorMinusY;
            private byte _gpsStatusFlag;
            private uint _gpsFixTime;
            private uint _gpsLatitude;
            private uint _gpsLongitude;
            private uint _gpsAltitude;
            private ushort _sbandTxCount;
            private ushort _antennaStatusFlag;
            private byte _acsStateFlag;
            private byte _acsParametersFlag;
            private Greencube m_root;
            private Greencube.GreencubeTlmFrame m_parent;
            public ushort UnixTimeMs { get { return _unixTimeMs; } }
            public uint UnixTime { get { return _unixTime; } }
            public ushort ProcessTime { get { return _processTime; } }
            public ushort SolarXVoltage { get { return _solarXVoltage; } }
            public ushort SolarYVoltage { get { return _solarYVoltage; } }
            public ushort SolarXCurrent { get { return _solarXCurrent; } }
            public ushort SolarYCurrent { get { return _solarYCurrent; } }
            public byte EpsBootcause { get { return _epsBootcause; } }
            public sbyte MpptXTemperature { get { return _mpptXTemperature; } }
            public sbyte MpptYTemperature { get { return _mpptYTemperature; } }
            public sbyte EpsTemperature { get { return _epsTemperature; } }
            public sbyte Battery1Temperature { get { return _battery1Temperature; } }
            public sbyte Battery2Temperature { get { return _battery2Temperature; } }
            public sbyte Battery3Temperature { get { return _battery3Temperature; } }
            public ushort SolarTotalCurrent { get { return _solarTotalCurrent; } }
            public ushort SystemTotalCurrent { get { return _systemTotalCurrent; } }
            public ushort BatteryVoltage { get { return _batteryVoltage; } }
            public byte EpsOutputs { get { return _epsOutputs; } }
            public sbyte RadioPaTemperature { get { return _radioPaTemperature; } }
            public ushort RadioTxCount { get { return _radioTxCount; } }
            public ushort RadioRxCount { get { return _radioRxCount; } }
            public short RadioLastRssi { get { return _radioLastRssi; } }
            public ushort ObcBootCount { get { return _obcBootCount; } }
            public ushort RadioBootCount { get { return _radioBootCount; } }
            public ushort EpsBootCount { get { return _epsBootCount; } }
            public byte PayloadRxCount { get { return _payloadRxCount; } }
            public byte PayloadTxCount { get { return _payloadTxCount; } }
            public byte SoftwareStatus { get { return _softwareStatus; } }
            public byte HeaterStatus { get { return _heaterStatus; } }
            public byte ObcTemperature { get { return _obcTemperature; } }
            public short GyroscopeX { get { return _gyroscopeX; } }
            public short GyroscopeY { get { return _gyroscopeY; } }
            public short GyroscopeZ { get { return _gyroscopeZ; } }
            public short MagnetometerX { get { return _magnetometerX; } }
            public short MagnetometerY { get { return _magnetometerY; } }
            public short MagnetometerZ { get { return _magnetometerZ; } }
            public sbyte SolarpanelPlusXTemperature { get { return _solarpanelPlusXTemperature; } }
            public sbyte SolarpanelPlusYTemperature { get { return _solarpanelPlusYTemperature; } }
            public sbyte SolarpanelMinusXTemperature { get { return _solarpanelMinusXTemperature; } }
            public sbyte SolarpanelMinusYTemperature { get { return _solarpanelMinusYTemperature; } }
            public ushort CoarseSunSensorPlusX { get { return _coarseSunSensorPlusX; } }
            public ushort CoarseSunSensorPlusY { get { return _coarseSunSensorPlusY; } }
            public ushort CoarseSunSensorMinusX { get { return _coarseSunSensorMinusX; } }
            public ushort CoarseSunSensorMinusY { get { return _coarseSunSensorMinusY; } }
            public byte GpsStatusFlag { get { return _gpsStatusFlag; } }
            public uint GpsFixTime { get { return _gpsFixTime; } }
            public uint GpsLatitude { get { return _gpsLatitude; } }
            public uint GpsLongitude { get { return _gpsLongitude; } }
            public uint GpsAltitude { get { return _gpsAltitude; } }
            public ushort SbandTxCount { get { return _sbandTxCount; } }
            public ushort AntennaStatusFlag { get { return _antennaStatusFlag; } }
            public byte AcsStateFlag { get { return _acsStateFlag; } }
            public byte AcsParametersFlag { get { return _acsParametersFlag; } }
            public Greencube M_Root { get { return m_root; } }
            public Greencube.GreencubeTlmFrame M_Parent { get { return m_parent; } }
        }
        private GreencubeTlmFrame _greencubeRawFrame;
        private Greencube m_root;
        private KaitaiStruct m_parent;

        /// <remarks>
        /// Reference: <a href="https://www.s5lab.space/index.php/decoding-ledsat-2/">Source</a>
        /// </remarks>
        public GreencubeTlmFrame GreencubeRawFrame { get { return _greencubeRawFrame; } }
        public Greencube M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }

}
