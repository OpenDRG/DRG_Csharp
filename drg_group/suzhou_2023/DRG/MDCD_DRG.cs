namespace drg_group.suzhou_2023
{
    public class MDCD_DRG 
    {
    
        public static bool DA19_group(MedicalRecord record){
            return true;
        }
    
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
    
        public static bool DG29_group(MedicalRecord record){
            return true;
        }
    
        public static bool DJ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DK19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DV19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DR11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool DU11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool DZ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool DE1A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool DS1A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool DT1A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool DT2A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool DW1A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool DU13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool DZ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool DR1B_group(MedicalRecord record){
            return true;
        }
    
        public static bool DE15_group(MedicalRecord record){
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
    
        public static bool DW15_group(MedicalRecord record){
            return true;
        }
    
        public static bool DZ15_group(MedicalRecord record){
            return true;
        }
    
    }
}
