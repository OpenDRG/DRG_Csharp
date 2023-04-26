namespace drg_group.linfen_2022
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
    
        public static bool IC29_group(MedicalRecord record){
            return true;
        }
    
        public static bool ID19_group(MedicalRecord record){
            return true;
        }
    
        public static bool IF39_group(MedicalRecord record){
            return true;
        }
    
        public static bool IG19_group(MedicalRecord record){
            return true;
        }
    
        public static bool IR19_group(MedicalRecord record){
            return true;
        }
    
        public static bool IR29_group(MedicalRecord record){
            return true;
        }
    
        public static bool IS19_group(MedicalRecord record){
            return true;
        }
    
        public static bool IT39_group(MedicalRecord record){
            return true;
        }
    
        public static bool IU29_group(MedicalRecord record){
            return true;
        }
    
        public static bool IU39_group(MedicalRecord record){
            return true;
        }
    
        public static bool IV19_group(MedicalRecord record){
            return true;
        }
    
        public static bool IZ19_group(MedicalRecord record){
            return true;
        }
    
        public static bool IC31_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IF51_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IS21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IT11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IT21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IZ21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IC13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IC43_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IE13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IF13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IF23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IF43_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IH13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IJ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IS23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IT23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IU13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IC15_group(MedicalRecord record){
            return true;
        }
    
        public static bool IC35_group(MedicalRecord record){
            return true;
        }
    
        public static bool IC45_group(MedicalRecord record){
            return true;
        }
    
        public static bool IE15_group(MedicalRecord record){
            return true;
        }
    
        public static bool IF15_group(MedicalRecord record){
            return true;
        }
    
        public static bool IF25_group(MedicalRecord record){
            return true;
        }
    
        public static bool IF45_group(MedicalRecord record){
            return true;
        }
    
        public static bool IF55_group(MedicalRecord record){
            return true;
        }
    
        public static bool IH15_group(MedicalRecord record){
            return true;
        }
    
        public static bool IJ15_group(MedicalRecord record){
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
    
        public static bool IZ25_group(MedicalRecord record){
            return true;
        }
    
    }
}
