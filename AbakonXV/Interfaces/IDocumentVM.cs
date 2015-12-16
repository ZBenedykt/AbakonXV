namespace AbakonXVWPF.Interfaces
{



    public interface ITask
    {
        ITask CurrentTask
        {
            get;
            set;
        }
    }

    public interface IPartner
    {
        IPartner CurrentPartner
        {
            get;
            set;
        }
    }

    public interface IPerson
    {
        IPerson CurrentPerson
        {
            get;
            set;
        }
    }

    public interface IDocument
    {
        IDocument CurrentDocument
        {
            get;
            set;
        }
    }

}
