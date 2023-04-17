namespace drg_group.changzhou_2022
{
    public class MDCZ_DRG 
    {
    
        public static bool ZB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool ZD19_group(MedicalRecord record){
            return true;
        }
    
        public static bool ZZ17_group(MedicalRecord record){
            return record.inHospitalTime<5 && (record.leavingType.Equals("2") || record.leavingType.Equals("5"));
        }
    
        public static bool ZJ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool ZZ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool ZJ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool ZZ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool ZJ15_group(MedicalRecord record){
            return true;
        }
    
        public static bool ZZ15_group(MedicalRecord record){
            return true;
        }
    
    }
}
