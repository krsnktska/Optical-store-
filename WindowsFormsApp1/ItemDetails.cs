using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class ItemDetails : Form
	{
		private int userId;
		private Item currentItem;

		public ItemDetails(int userId, Item item)
		{
			InitializeComponent();
			this.userId = userId;
			this.currentItem = item;
			StartPosition = FormStartPosition.CenterScreen;
			ItemDetailsLoad();
		}

		private void ItemDetailsLoad()
		{
			itemName.Text = currentItem.NameOfTheProduct;
			itemCost.Text = $@"Ціна: {currentItem.Cost} грн";
			itemCountOf.Text = $@"Залишилось: {currentItem.CountOf.ToString()}";
			itemProducer.Text = $@"Виробник: {currentItem.Producer}";
			itemDescription.Text = $@"Опис: {currentItem.Description}";


			//propertiesFlowPanel
		}
	}
}
