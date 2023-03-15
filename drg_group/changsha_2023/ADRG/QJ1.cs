namespace drg_group.changsha_2023{
    public class QJ1
    {
        public static String group(MedicalRecord record)
        {
            String[] adrg_zd={};
            String[] adrg_zd1={};
            String[] adrg_ss={"00.1101","00.1400x002","00.1500x001","00.1801","00.1802","16.9200","16.9300x003","18.2101","18.2900x009","18.2902","18.2903","18.2904","18.2905","18.3901","20.5100x002","21.3101","21.3102","21.3103","21.3104","21.3105","21.3106","21.3107","21.3108","21.3109","21.3201","21.4x00","26.2901","26.2902","26.2903","26.2904","26.2906","26.3000","26.3100x008","26.3100x009","26.3101","26.3102","26.3103","26.3104","26.3105","26.3201","26.3202","26.3203","27.4200","27.4301","27.4302","27.4900x007","27.4902","27.4903","27.4905","27.4906","27.4907","27.4908","27.4909","27.4910","27.9900x005","27.9901","27.9902","28.9200x002","28.9201","28.9202","29.3900x001","29.3900x007","29.3900x017","29.3902","32.3001","32.3902","34.0200x001","34.0200x003","34.0401","34.2000","34.2100x001","34.2200","34.2502","34.2600","34.4x01","34.4x03","34.5901","38.7x01","38.7x02","38.7x03","38.7x04","38.8606","39.7900x809","39.7904","39.9000x010","40.0x00x001","40.0x00x002","40.0x01","40.1100x003","40.1100x004","40.2200","40.2400","40.2900x002","40.2900x008","40.2900x019","40.2900x020","40.2900x030","40.2900x031","40.2902","40.2904","40.2906","40.2908","40.2910","40.3x00x001","40.3x00x002","40.4100","40.4200","40.5000","40.5100","40.5101","40.5301","40.5400x001","40.5400x002","40.5400x003","40.5900x010","40.5900x021","40.5901","40.5905","40.5906","40.5907","40.5908","40.5909","40.5910","40.5911","40.5912","40.5914","40.6100","40.6200","40.6300","40.6301","40.6400","40.6900x002","40.6900x003","40.6900x004","40.6901","40.9x00x003","40.9x00x004","40.9x00x006","40.9x00x007","40.9x00x008","40.9x00x009","40.9x00x010","40.9x00x011","40.9x00x012","40.9x00x013","40.9x00x014","40.9x00x015","40.9x00x016","40.9x00x017","40.9x01","40.9x02","40.9x03","40.9x04","40.9x05","40.9x06","40.9x07","40.9x08","40.9x09","41.1x00","41.3300","41.9100x001","41.9200","41.9201","41.9202","41.9203","41.9900x003","45.4200x003","51.2300","54.1100","54.1101","54.1900x001","54.1900x005","54.1900x010","54.1900x011","54.1900x020","54.1901","54.1902","54.1904","54.1907","54.2100","54.2300x003","54.2300x004","54.2300x005","54.2300x006","54.2301","54.2302","54.2303","54.3x01","54.3x02","54.3x03","54.3x04","54.3x05","54.3x06","54.3x07","54.4x00x012","54.4x00x021","54.4x00x035","54.4x01","54.4x02","54.4x07","54.4x11","54.4x12","54.4x13","54.4x14","54.4x15","54.4x16","54.9900x011","54.9904","66.5102","67.3903","67.3904","68.2906","68.2907","68.2912","68.2917","68.2918","68.3104","70.3200x002","70.3201","71.3x00x001","71.3x00x011","71.3x01","71.3x04","85.2100x003","85.2100x019","86.2200x011","86.2800x012","99.2600","99.2800x003","99.2800x006","99.2801","99.2802","99.2900x007","99.2902","99.2904","99.2905","99.6000","99.6200x001","99.6201","99.6300x001","99.7200","99.7200x002","99.7300"};
            String[] adrg_ss1={};
            
            if (true && record.ssList!=null &&record.ssList.Length>0 && adrg_ss.Contains(record.ssList[0])){
                Base.groupMessages.putMessage(record.Index,"符合QJ1入组条件，匹配规则：主手术匹配");
                    
                if (MDCQ_DRG.QJ13_group(record))
                {
                    return "QJ13";
                }
    
                if (MDCQ_DRG.QJ15_group(record))
                {
                    return "QJ15";
                }

                return "QJ1";
            }else{
                return "";
            }
        }
    }
}