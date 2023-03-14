namespace drg_group.zhejiang_2022
{
    public class MDCX_DRG 
    {
    
        public static bool XJ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool XR29_group(MedicalRecord record){
            return true;
        }
    
        public static bool XS19_group(MedicalRecord record){
            return true;
        }
    
        public static bool XS29_group(MedicalRecord record){
            return true;
        }
    
        public static bool XT19_group(MedicalRecord record){
            return true;
        }
    
        public static bool XT39_group(MedicalRecord record){
            return true;
        }
    
        public static bool XR11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool XT21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool XR13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool XT23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool XR15_group(MedicalRecord record){
            return true;
        }
    
        public static bool XT25_group(MedicalRecord record){
            return true;
        }
    
    }
}
