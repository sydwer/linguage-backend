# This file is auto-generated from the current state of the database. Instead
# of editing this file, please use the migrations feature of Active Record to
# incrementally modify your database, and then regenerate this schema definition.
#
# This file is the source Rails uses to define your schema when running `rails
# db:schema:load`. When creating a new database, `rails db:schema:load` tends to
# be faster and is potentially less error prone than running all of your
# migrations from scratch. Old migrations may fail to apply correctly if those
# migrations use external dependencies or application code.
#
# It's strongly recommended that you check this file into your version control system.

ActiveRecord::Schema.define(version: 2019_12_30_224104) do

  create_table "comparisons", force: :cascade do |t|
    t.integer "native_language_id"
    t.integer "target_language_id"
    t.float "contrastive_value"
    t.datetime "created_at", precision: 6, null: false
    t.datetime "updated_at", precision: 6, null: false
  end

  create_table "language_families", force: :cascade do |t|
    t.string "specific_family"
    t.string "general_family"
    t.float "x_coordinate"
    t.float "y_coordinate"
    t.datetime "created_at", precision: 6, null: false
    t.datetime "updated_at", precision: 6, null: false
  end

  create_table "language_phonemes", force: :cascade do |t|
    t.integer "language_id"
    t.integer "phoneme_id"
    t.datetime "created_at", precision: 6, null: false
    t.datetime "updated_at", precision: 6, null: false
    t.index ["language_id"], name: "index_language_phonemes_on_language_id"
    t.index ["phoneme_id"], name: "index_language_phonemes_on_phoneme_id"
  end

  create_table "languages", force: :cascade do |t|
    t.string "name"
    t.string "written_name"
    t.string "hello"
    t.string "speakers"
    t.string "flag"
    t.string "duolingo"
    t.string "contrastive_diacritic"
    t.string "syllable_structure"
    t.string "syllable_structure_2"
    t.string "mary"
    t.string "john"
    t.integer "morphology_id"
    t.integer "language_family_id"
    t.integer "orthography_id"
    t.integer "noun_classes"
    t.datetime "created_at", precision: 6, null: false
    t.datetime "updated_at", precision: 6, null: false
  end

  create_table "morphologies", force: :cascade do |t|
    t.string "name"
    t.integer "coordinate_value"
    t.datetime "created_at", precision: 6, null: false
    t.datetime "updated_at", precision: 6, null: false
  end

  create_table "orthographies", force: :cascade do |t|
    t.string "name"
    t.string "system"
    t.integer "coordinate_value"
    t.datetime "created_at", precision: 6, null: false
    t.datetime "updated_at", precision: 6, null: false
  end

  create_table "phonemes", force: :cascade do |t|
    t.string "symbol"
    t.string "place"
    t.string "manner"
    t.string "category"
    t.datetime "created_at", precision: 6, null: false
    t.datetime "updated_at", precision: 6, null: false
  end

  add_foreign_key "language_phonemes", "languages"
  add_foreign_key "language_phonemes", "phonemes"
end
