class Comparison < ApplicationRecord
    belongs_to :native_language, class_name: 'Language'
    belongs_to :target_language, class_name: 'Language'
end
