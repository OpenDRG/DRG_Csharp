namespace drg_group.suzhou_2022
{
    public class MDCN_DRG 
    {
    
        public static bool NA19_group(MedicalRecord record){
            return true;
        }
    
        public static bool NA29_group(MedicalRecord record){
            return true;
        }
    
        public static bool NB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool NC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool ND19_group(MedicalRecord record){
            return true;
        }
    
        public static bool NE19_group(MedicalRecord record){
            return true;
        }
    
        public static bool NF19_group(MedicalRecord record){
            return true;
        }
    
        public static bool NG19_group(MedicalRecord record){
            return true;
        }
    
        public static bool NZ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool NR11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool NJ1A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool NS1A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool NR13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool NJ15_group(MedicalRecord record){
            return true;
        }
    
        public static bool NR15_group(MedicalRecord record){
            return true;
        }
    
        public static bool NS15_group(MedicalRecord record){
            return true;
        }
    
    }
}
