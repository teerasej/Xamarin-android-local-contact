using System;
using Android.Views;
using Android.Widget;

namespace LocalContact
{
    public class ContactModelListAdapter : BaseAdapter<ContactModel>
    {

        public ContactModelListAdapter()
        {
        }

        public override ContactModel this[int position] => throw new NotImplementedException();

        public override int Count => throw new NotImplementedException();

        public override long GetItemId(int position)
        {
            throw new NotImplementedException();
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            throw new NotImplementedException();
        }
    }
}
