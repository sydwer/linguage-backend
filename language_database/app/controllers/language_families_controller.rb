class LanguageFamiliesController < ApplicationController
    def index
        language_families = LanguageFamily.all 
        render json: language_families
    end

    def show
        language_family = LanguageFamily.find(params[:id])
        render json: language_family
    end
end
