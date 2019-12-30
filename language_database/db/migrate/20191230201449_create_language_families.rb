class CreateLanguageFamilies < ActiveRecord::Migration[6.0]
  def change
    create_table :language_families do |t|
      t.string :specific_family
      t.string :general_family
      t.float :x_coordinate
      t.float :y_coordinate
      t.timestamps
    end
  end
end
