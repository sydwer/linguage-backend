class PhonemesController < ApplicationController
    def index
        phonemes = Phoneme.all 
        render json: phonemes, include: :languages
    end

    def show
        phoneme = Phoneme.find(params[:id])
        render json: phoneme, include: :languages
    end
end
