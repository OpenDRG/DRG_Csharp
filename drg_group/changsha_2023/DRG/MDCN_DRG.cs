namespace drg_group.changsha_2023
{
    public class MDCN_DRG 
    {
    
        public static bool NB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool NC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool ND19_group(MedicalRecord record){
            return true;
        }
    
        public static bool NG19_group(MedicalRecord record){
            return true;
        }
    
        public static bool NA11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool NA21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool NE11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool NR11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool NZ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool NA23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool NF13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool NJ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool NS13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool NA15_group(MedicalRecord record){
            return true;
        }
    
        public static bool NA25_group(MedicalRecord record){
            return true;
        }
    
        public static bool NE15_group(MedicalRecord record){
            return true;
        }
    
        public static bool NF15_group(MedicalRecord record){
            return true;
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
    
        public static bool NZ15_group(MedicalRecord record){
            return true;
        }
    
    }
}
