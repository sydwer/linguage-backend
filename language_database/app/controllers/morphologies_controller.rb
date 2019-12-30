class MorphologiesController < ApplicationController
    def index
        morphologies = Morphology.all
        render json: morphologies
    end

    def show
        morphology = Morphology.find(params[:id])
        render json: morphology
    end
end
