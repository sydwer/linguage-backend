class CreateComparisons < ActiveRecord::Migration[6.0]
  def change
    create_table :comparisons do |t|
      t.integer :native_language_id
      t.integer :target_language_id
      t.float :contrastive_value
      t.timestamps
    end
  end
end
