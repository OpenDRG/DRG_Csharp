namespace drg_group.beijing_2022
{
    public class MDCC_DRG 
    {
    
        public static bool CJ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool CV19_group(MedicalRecord record){
            return true;
        }
    
        public static bool CB39_group(MedicalRecord record){
            return true;
        }
    
        public static bool CB49_group(MedicalRecord record){
            return true;
        }
    
        public static bool CR19_group(MedicalRecord record){
            return true;
        }
    
        public static bool CX19_group(MedicalRecord record){
            return true;
        }
    
        public static bool CW19_group(MedicalRecord record){
            return true;
        }
    
        public static bool CB13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool CD23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool CZ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool CB23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool CS13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool CT13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool CU13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool CC13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool CZ15_group(MedicalRecord record){
            return true;
        }
    
        public static bool CS15_group(MedicalRecord record){
            return true;
        }
    
        public static bool CC15_group(MedicalRecord record){
            return true;
        }
    
        public static bool CT15_group(MedicalRecord record){
            return true;
        }
    
        public static bool CU15_group(MedicalRecord record){
            return true;
        }
    
        public static bool CB15_group(MedicalRecord record){
            return true;
        }
    
        public static bool CD25_group(MedicalRecord record){
            return true;
        }
    
        public static bool CB25_group(MedicalRecord record){
            return true;
        }
    
        public static bool CD1D_group(MedicalRecord record){
            return record.age<=6;
        }
    
        public static bool CD19_group(MedicalRecord record){
            return true;
        }
    
    }
}
