using System;
using System.Collections.Generic;
using ICT13580013FinalB.Models;
using Xamarin.Forms;

namespace ICT13580013FinalB
{
    public partial class ProductNewPage : ContentPage
    {
        Product product;

        public ProductNewPage(Product product = null)
        {
            InitializeComponent();

            this.product = product;

            titleLabel.Text = product == null ? "เพิ่มสินค้า" : "แก้ไขข้อมูลสินค้า";


            saveButton.Clicked += SaveButton_Clicked;
            cancelButton.Clicked += CancelButton_Clicked;

            sexPicker.Items.Add("ชาย");
            sexPicker.Items.Add("หญิง");

            statusPicker.Items.Add("แต่งงานแล้ว");
            statusPicker.Items.Add("โสด");

            departmentPicker.Items.Add("การเงิน");
            departmentPicker.Items.Add("การตลาด");

            if (product != null)
            {

                nameEntry.Text = product.Name;
                lastNameEntry.Text = product.LastName;
                ageEntry.Text = product.Age.ToString();
                sexPicker.SelectedItem = product.Sex;

                departmentPicker.SelectedItem = product.Department;
                telEntry.Text = product.Tel.ToString();

                emailEntry.Text = product.Email;


                addressEditor.Text = product.Address;

                statusPicker.SelectedItem = product.Status;

                childEntry.Text = product.Child.ToString();

                saralyEntry.Text = product.Saraly.ToString();



            }

        }



		async void SaveButton_Clicked(object sender, EventArgs e)
        {
            var isOk = await DisplayAlert("ยืนยัน", "คุณต้องการบันทึกใช่หรือไม่", "ใช่", "ไม่ใช่");
            if (isOk)
            {
                if (product == null)
                {
                    var product = new Product();
                    product.Name = nameEntry.Text;
                    product.LastName = lastNameEntry.Text;
                    product.Age = int.Parse(ageEntry.Text);
                    product.Sex = sexPicker.SelectedItem.ToString();
                    product.Department = departmentPicker.SelectedItem.ToString();
                    product.Tel = int.Parse(telEntry.Text);
                    product.Email = emailEntry.Text;
                    product.Address = addressEditor.Text;
                    product.Status = statusPicker.SelectedItem.ToString();
                    product.Child = int.Parse(childEntry.Text);
                    product.Saraly = int.Parse(saralyEntry.Text);


                    var id = App.DbHelpers.UpdateProduct(product);
                    await DisplayAlert("บันทึกสำเร็จ", "รหัสสมาชิกของท่านคือ" + id, "ตกลง");
                }
                else
                {
					product.Name = nameEntry.Text;
					product.LastName = lastNameEntry.Text;
					product.Age = int.Parse(ageEntry.Text);
					product.Sex = sexPicker.SelectedItem.ToString();
					product.Department = departmentPicker.SelectedItem.ToString();
					product.Tel = int.Parse(telEntry.Text);
					product.Email = emailEntry.Text;
					product.Address = addressEditor.Text;
					product.Status = statusPicker.SelectedItem.ToString();
					product.Child = int.Parse(childEntry.Text);
					product.Saraly = int.Parse(saralyEntry.Text);

					var id = App.DbHelpers.UpdateProduct(product);
					await DisplayAlert("บันทึกสำเร็จ", "แก้ไขข้อมูลสินค้าเรียบร้อย" + id, "ตกลง");
                
                
                
                
                }
				await Navigation.PopModalAsync();



			}
        }

        void CancelButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();

        }
    }
}
