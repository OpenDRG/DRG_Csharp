namespace drg_group.wuhan_2022
{
    public class MDCV_DRG 
    {
    
        public static bool VB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool VC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool VR19_group(MedicalRecord record){
            return true;
        }
    
        public static bool VZ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool VJ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool VS21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool VS1A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool VT1A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool VJ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool VS23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool VJ15_group(MedicalRecord record){
            return true;
        }
    
        public static bool VS15_group(MedicalRecord record){
            return true;
        }
    
        public static bool VS25_group(MedicalRecord record){
            return true;
        }
    
        public static bool VT15_group(MedicalRecord record){
            return true;
        }
    
    }
}
