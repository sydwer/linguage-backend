Rails.application.routes.draw do
  resources :comparisons
  resources :language_phonemes
  resources :languages
  resources :language_families
  resources :morphologies
  resources :orthographies
  resources :phonemes
  # For details on the DSL available within this file, see https://guides.rubyonrails.org/routing.html
end
