namespace drg_group.qingdao_2023
{
    public class MDCD_DRG 
    {
    
        public static bool DB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DB29_group(MedicalRecord record){
            return true;
        }
    
        public static bool DB39_group(MedicalRecord record){
            return true;
        }
    
        public static bool DC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DC29_group(MedicalRecord record){
            return true;
        }
    
        public static bool DD19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DD29_group(MedicalRecord record){
            return true;
        }
    
        public static bool DE29_group(MedicalRecord record){
            return true;
        }
    
        public static bool DG19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DV19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DW19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DE11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool DG21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool DJ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool DK11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool DR11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool DU11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool DA13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool DE13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool DG23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool DJ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool DR13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool DS13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool DT13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool DT23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool DU13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool DZ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool DA15_group(MedicalRecord record){
            return true;
        }
    
        public static bool DE15_group(MedicalRecord record){
            return true;
        }
    
        public static bool DG25_group(MedicalRecord record){
            return true;
        }
    
        public static bool DJ15_group(MedicalRecord record){
            return true;
        }
    
        public static bool DK15_group(MedicalRecord record){
            return true;
        }
    
        public static bool DR15_group(MedicalRecord record){
            return true;
        }
    
        public static bool DS15_group(MedicalRecord record){
            return true;
        }
    
        public static bool DT15_group(MedicalRecord record){
            return true;
        }
    
        public static bool DT25_group(MedicalRecord record){
            return true;
        }
    
        public static bool DU15_group(MedicalRecord record){
            return true;
        }
    
        public static bool DZ15_group(MedicalRecord record){
            return true;
        }
    
    }
}
