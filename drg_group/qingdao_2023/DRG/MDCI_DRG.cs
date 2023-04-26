namespace drg_group.qingdao_2023
{
    public class MDCI_DRG 
    {
    
        public static bool IB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool IB29_group(MedicalRecord record){
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
    
        public static bool IF29_group(MedicalRecord record){
            return true;
        }
    
        public static bool IR29_group(MedicalRecord record){
            return true;
        }
    
        public static bool IS29_group(MedicalRecord record){
            return true;
        }
    
        public static bool IT19_group(MedicalRecord record){
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
    
        public static bool IB31_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IF31_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IF51_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IH11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IS11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IT21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IZ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IE13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IF33_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IF43_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IG13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IH13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IJ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IR13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IT23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IT33_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IU13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IZ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IZ23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IB35_group(MedicalRecord record){
            return true;
        }
    
        public static bool IE15_group(MedicalRecord record){
            return true;
        }
    
        public static bool IF35_group(MedicalRecord record){
            return true;
        }
    
        public static bool IF45_group(MedicalRecord record){
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
    
        public static bool IT25_group(MedicalRecord record){
            return true;
        }
    
        public static bool IT35_group(MedicalRecord record){
            return true;
        }
    
        public static bool IU15_group(MedicalRecord record){
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
