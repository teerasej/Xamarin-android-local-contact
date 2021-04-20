using System;
using System.Collections.Generic;
using Android.App;
using Android.Views;
using Android.Widget;

namespace LocalContact
{
    public class ContactModelListAdapter : BaseAdapter<ContactModel>
    {
        ContactModel[] contacts;
        Activity context;

        public ContactModelListAdapter(Activity context, ContactModel[] contacts)
        {
            this.context = context;
            this.contacts = contacts;
        }

        public override ContactModel this[int position] => this.contacts[position];

        public override int Count => this.contacts.Length;

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView; // re-use an existing view, if one is available
            if (view == null) // otherwise create a new one
                view = context.LayoutInflater.Inflate(Resource.Layout.list_item_contact, null);

            view.FindViewById<TextView>(Resource.Id.textName).Text = contacts[position].Name;
            view.FindViewById<TextView>(Resource.Id.textPhoneNumber).Text = contacts[position].PhoneNumber;
            return view;
        }
    }
}
