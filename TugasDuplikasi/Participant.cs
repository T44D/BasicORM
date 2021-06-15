namespace TugasDuplikasi
{
    class Participant
    {
        public string Nik { get; set; }
        public string ParticipantName { get; set; }
        public CodingCamp CodingCamp { get; set; }

        public Participant() {}

        public Participant(string nik, string participantName, CodingCamp codingCamp)
        {
            Nik = nik;
            ParticipantName = participantName;
            CodingCamp = codingCamp;
        }
    }
}
