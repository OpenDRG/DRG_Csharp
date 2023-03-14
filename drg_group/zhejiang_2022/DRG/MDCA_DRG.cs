namespace drg_group.zhejiang_2022
{
    public class MDCA_DRG 
    {
    
        public static bool AA19_group(MedicalRecord record){
            return true;
        }
    
        public static bool AB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool AC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool AD19_group(MedicalRecord record){
            return true;
        }
    
        public static bool AE19_group(MedicalRecord record){
            return true;
        }
    
        public static bool AF19_group(MedicalRecord record){
            return true;
        }
    
        public static bool AG19_group(MedicalRecord record){
            return true;
        }
    
        public static bool AG29_group(MedicalRecord record){
            return true;
        }
    
        public static bool AH13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool AH11_group(MedicalRecord record){
            return record.ssList.Length>1 && record.ssList.Contains("39.6500");
        }
    
        public static bool AH19_group(MedicalRecord record){
            return record.ssList.Length>1 && Base.intersect(record.ssList,new String[]{"31.1x00x005","31.2100x001","31.2900x001","96.0400"}) && record.ssList.Contains("96.7201");
        }
    
    }
}
