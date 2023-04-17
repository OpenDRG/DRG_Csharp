namespace drg_group.suzhou_2023
{
    public class MDCI_DRG 
    {
    
        public static bool IB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool IB29_group(MedicalRecord record){
            return true;
        }
    
        public static bool IB39_group(MedicalRecord record){
            return true;
        }
    
        public static bool IC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool IC29_group(MedicalRecord record){
            return true;
        }
    
        public static bool IC39_group(MedicalRecord record){
            return true;
        }
    
        public static bool IC49_group(MedicalRecord record){
            return true;
        }
    
        public static bool ID19_group(MedicalRecord record){
            return true;
        }
    
        public static bool IF19_group(MedicalRecord record){
            return true;
        }
    
        public static bool IF39_group(MedicalRecord record){
            return true;
        }
    
        public static bool IF49_group(MedicalRecord record){
            return true;
        }
    
        public static bool IR29_group(MedicalRecord record){
            return true;
        }
    
        public static bool IT39_group(MedicalRecord record){
            return true;
        }
    
        public static bool IV19_group(MedicalRecord record){
            return true;
        }
    
        public static bool IU31_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IE1A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IF2A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IF5A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IG1A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IH1A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IJ1A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IR1A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IS1A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IS2A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IT1A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IT2A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IU1A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IU2A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IZ1A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IZ2A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IU33_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IE15_group(MedicalRecord record){
            return true;
        }
    
        public static bool IF25_group(MedicalRecord record){
            return true;
        }
    
        public static bool IF55_group(MedicalRecord record){
            return true;
        }
    
        public static bool IG15_group(MedicalRecord record){
            return true;
        }
    
        public static bool IH15_group(MedicalRecord record){
            return true;
        }
    
        public static bool IJ15_group(MedicalRecord record){
            return true;
        }
    
        public static bool IR15_group(MedicalRecord record){
            return true;
        }
    
        public static bool IS15_group(MedicalRecord record){
            return true;
        }
    
        public static bool IS25_group(MedicalRecord record){
            return true;
        }
    
        public static bool IT15_group(MedicalRecord record){
            return true;
        }
    
        public static bool IT25_group(MedicalRecord record){
            return true;
        }
    
        public static bool IU15_group(MedicalRecord record){
            return true;
        }
    
        public static bool IU25_group(MedicalRecord record){
            return true;
        }
    
        public static bool IU35_group(MedicalRecord record){
            return true;
        }
    
        public static bool IZ15_group(MedicalRecord record){
            return true;
        }
    
        public static bool IZ25_group(MedicalRecord record){
            return true;
        }
    
    }
}
