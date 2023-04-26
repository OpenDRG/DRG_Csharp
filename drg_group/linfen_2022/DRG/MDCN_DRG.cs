namespace drg_group.linfen_2022
{
    public class MDCN_DRG 
    {
    
        public static bool NA19_group(MedicalRecord record){
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
    
        public static bool NJ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool NS19_group(MedicalRecord record){
            return true;
        }
    
        public static bool NB11_group(MedicalRecord record){
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
    
        public static bool NB13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool NF13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool NR13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool NA25_group(MedicalRecord record){
            return true;
        }
    
        public static bool NB15_group(MedicalRecord record){
            return true;
        }
    
        public static bool NF15_group(MedicalRecord record){
            return true;
        }
    
        public static bool NR15_group(MedicalRecord record){
            return true;
        }
    
        public static bool NZ15_group(MedicalRecord record){
            return true;
        }
    
    }
}
