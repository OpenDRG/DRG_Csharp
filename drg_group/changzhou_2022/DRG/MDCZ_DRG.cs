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
    
        public static bool ZC14_group(MedicalRecord record){
            return record.ssList.length>1 && Base.intersect(record.ssList[1..],new String[]{"31.1x00x005","31.2100x001","31.2900x001","31.7400","31.7400x001","96.0400"});
        }
    
        public static bool ZC18_group(MedicalRecord record){
            return true;
        }
    
    }
}
