namespace drg_group.chs_drg_10
{
    public class MDCD_DRG 
    {
    
        public static bool DA19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DD19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DD29_group(MedicalRecord record){
            return true;
        }
    
        public static bool DE19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DE29_group(MedicalRecord record){
            return true;
        }
    
        public static bool DG19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DG39_group(MedicalRecord record){
            return true;
        }
    
        public static bool DJ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DK19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DS19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DT19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DT29_group(MedicalRecord record){
            return true;
        }
    
        public static bool DV19_group(MedicalRecord record){
            return true;
        }
    
        public static bool DB21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool DC21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool DG21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool DR11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool DU11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool DW11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool DZ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool DB23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool DC23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool DG23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool DR13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool DU13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool DW13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool DZ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool DB25_group(MedicalRecord record){
            return true;
        }
    
        public static bool DC25_group(MedicalRecord record){
            return true;
        }
    
        public static bool DG25_group(MedicalRecord record){
            return true;
        }
    
        public static bool DR15_group(MedicalRecord record){
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
