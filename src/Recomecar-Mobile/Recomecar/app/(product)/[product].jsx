import { useEffect, useState } from "react";
import { useLocalSearchParams } from "expo-router";
import { View, Text, FlatList, RefreshControl } from "react-native";
import { SafeAreaView } from "react-native-safe-area-context";

import useAppwrite from "../../lib/useAppwrite";
import { getAllPosts, productInfo, searchPosts } from "../../lib/appwrite";
import { EstadoVazio, SearchInput } from "../../components";
import ProductCard from "../../components/ProductCard";

import { productId } from "../(tabs)/home"

const Product = () => {

  
  return (
    <SafeAreaView className='h-full'>
      <Text>{productId}</Text>
        
    </SafeAreaView>
  )
}

export default Product