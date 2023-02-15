namespace drg_group.wuhan_2022
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
    
        public static bool IE19_group(MedicalRecord record){
            return true;
        }
    
        public static bool IF29_group(MedicalRecord record){
            return true;
        }
    
        public static bool IF49_group(MedicalRecord record){
            return true;
        }
    
        public static bool IR19_group(MedicalRecord record){
            return true;
        }
    
        public static bool IR39_group(MedicalRecord record){
            return true;
        }
    
        public static bool IU19_group(MedicalRecord record){
            return true;
        }
    
        public static bool IU29_group(MedicalRecord record){
            return true;
        }
    
        public static bool IV19_group(MedicalRecord record){
            return true;
        }
    
        public static bool IZ29_group(MedicalRecord record){
            return true;
        }
    
        public static bool IB31_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IF51_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IG11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IH11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IJ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IR21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IT11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IT21_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IU31_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool IZ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool ID1A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IF1A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IF3A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IS1A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IS2A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IT3A_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IB33_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IG13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool IF5B_group(MedicalRecord record){
            return true;
        }
    
        public static bool IH1B_group(MedicalRecord record){
            return true;
        }
    
        public static bool IJ1B_group(MedicalRecord record){
            return true;
        }
    
        public static bool IR2B_group(MedicalRecord record){
            return true;
        }
    
        public static bool IT1B_group(MedicalRecord record){
            return true;
        }
    
        public static bool IT2B_group(MedicalRecord record){
            return true;
        }
    
        public static bool IU3B_group(MedicalRecord record){
            return true;
        }
    
        public static bool IZ1B_group(MedicalRecord record){
            return true;
        }
    
        public static bool IB35_group(MedicalRecord record){
            return true;
        }
    
        public static bool ID15_group(MedicalRecord record){
            return true;
        }
    
        public static bool IF15_group(MedicalRecord record){
            return true;
        }
    
        public static bool IF35_group(MedicalRecord record){
            return true;
        }
    
        public static bool IG15_group(MedicalRecord record){
            return true;
        }
    
        public static bool IS15_group(MedicalRecord record){
            return true;
        }
    
        public static bool IS25_group(MedicalRecord record){
            return true;
        }
    
        public static bool IT35_group(MedicalRecord record){
            return true;
        }
    
    }
}
