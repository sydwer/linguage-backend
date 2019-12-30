class ComparisonsController < ApplicationController
    def index
        unordered_comparisons = Comparison.all
        comparisons = unordered_comparisons.sort_by { |c| c[:contrastive_value] }
        render json: comparisons, include: [:native_language, :target_language]
    end

    def show
        comparison = Comparison.find(params[:id])
        render json: comparison, include: [:native_language, :target_language]
    end
end
