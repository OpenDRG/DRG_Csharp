namespace drg_group.qingyang_2023
{
    public class MDCN_DRG 
    {
    
        public static bool NA19_group(MedicalRecord record){
            return true;
        }
    
        public static bool NB19_group(MedicalRecord record){
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
    
        public static bool NJ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool NR11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool NA23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool NC13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool ND13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool NR13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool NS13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool NZ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool NA25_group(MedicalRecord record){
            return true;
        }
    
        public static bool NC15_group(MedicalRecord record){
            return true;
        }
    
        public static bool ND15_group(MedicalRecord record){
            return true;
        }
    
        public static bool NR15_group(MedicalRecord record){
            return true;
        }
    
        public static bool NS15_group(MedicalRecord record){
            return true;
        }
    
        public static bool NZ15_group(MedicalRecord record){
            return true;
        }
    
    }
}
