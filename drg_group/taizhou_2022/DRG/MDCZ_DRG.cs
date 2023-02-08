namespace drg_group.taizhou_2022
{
    public class MDCZ_DRG 
    {
    
        public static bool ZC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool ZJ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool ZD19_group(MedicalRecord record){
            return true;
        }
    
        public static bool ZZ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool ZB11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool ZB13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool ZZ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool ZB15_group(MedicalRecord record){
            return true;
        }
    
        public static bool ZZ15_group(MedicalRecord record){
            return true;
        }
    
    }
}
